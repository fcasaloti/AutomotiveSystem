using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class mainForm : Form
    {
        //declaring constants and variables
        const float radiator = 30.00f;
        const float transmission = 80.00f;
        const float oilChange = 28.50f;
        const float lubeJob = 19.50f;
        const float hourLabor = 21.80f;
        const float taxGST = 0.05f;
        const float taxPST = 0.07f;
        const float inspection = 15.00f;
        const float muffler = 90.50f;
        const float tireRotation = 28.90f;
        const float newTire = 87.75f;
        double servLaborTotal, partsTotal, laborTotal, tiresTotal, checkedNum;

        public mainForm()
        {
            InitializeComponent();
        }

        // Method To evaluate if Tires is selected inside miscLb
        private void miscLb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(miscLb.SelectedIndex.Equals(3)))
            {
                tiresLb.Visible = false;
                tiresLb.ClearSelected();
            }
            else
            {
                tiresLb.Visible = true;
                AddTires();
                tiresLb.SetSelected(0, true);
            }

        }

        //Method to add tires in the listbox
        private void AddTires()
        {
            if (miscLb.SelectedIndex.Equals(3) && tiresLb.Items.Count == 0)
            {
                for (int idx = 0; idx < 7; idx++)
                    tiresLb.Items.Add(idx + 1 + " tire(s)");
            }
        }

        private bool CheckForNumeric(string checkNum)
        {
            bool validation = false;
            if (double.TryParse(checkNum, out checkedNum))
                validation = true;

            return validation;
        }

        private void CalcPartsHours()
        {
            if (CheckForNumeric(partsTb.Text))
            {
                partsTotal = checkedNum;
                msgparts1Lb.Text = "";
                partsSumTb.Text = partsTotal.ToString("c2");
            }
            else
            {
                msgparts1Lb.Text = "Parts NOT numeric - $0 assumed";
                partsTotal = 0;
                partsSumTb.Text = partsTotal.ToString("c2");
            }
            
            if (CheckForNumeric(hoursTb.Text))
            {
                laborTotal = checkedNum;
                laborSumTb.BackColor = Color.Blue;
                laborSumTb.ForeColor = Color.White;
                msgparts2Lb.Text = "";
            }
            else
            {
                msgparts2Lb.Text = "Hours NOT numeric - $0 assumed";
                laborSumTb.BackColor = Color.Red;
                laborSumTb.ForeColor = Color.Yellow;
                laborTotal = 0;
            }
        }

            //Method to calculate the value for the laborSumTb
            private void CalcServiceLabor()
            {
                servLaborTotal = laborTotal * hourLabor;
                laborSumTb.Text = servLaborTotal.ToString("c2");
                if ((radiatorCb.Checked))
                    servLaborTotal = servLaborTotal + radiator;
                if ((transmissionCb.Checked))
                    servLaborTotal = servLaborTotal + transmission;
                if ((oilCb.Checked))
                    servLaborTotal = servLaborTotal + oilChange;
                if ((lubeCb.Checked))
                    servLaborTotal = servLaborTotal + lubeJob;
                if (miscLb.SelectedIndex.Equals(0))
                    servLaborTotal = servLaborTotal + inspection;
                if (miscLb.SelectedIndex.Equals(1))
                    servLaborTotal = servLaborTotal + muffler;
                if (miscLb.SelectedIndex.Equals(2))
                    servLaborTotal = servLaborTotal + tireRotation;
                if ((miscLb.SelectedIndex.Equals(3) && tiresLb.SelectedIndex >= 0))
                {
                    tiresTotal = (tiresLb.SelectedIndex + 1) * newTire;
                    servLaborTotal = servLaborTotal + tiresTotal;
                }

                serviceSumTb.Text = servLaborTotal.ToString("c2");
            }

            //Button to clear selections on MiscLisboxes
            private void clearMiscBt_Click(object sender, EventArgs e)
            {
                ClearMisc();
            }

            //Method to clear selection in Misc listboxes
            private void ClearMisc()
            {
                miscLb.ClearSelected();
                tiresLb.ClearSelected();
            }

            //Exit Form
            private void exitBt_Click(object sender, EventArgs e)
            {
                ActiveForm.Close();
            }

            //Button to clear Form
            private void clearBt_Click(object sender, EventArgs e)
            {
                ClearMisc();

                radiatorCb.Checked = false;
                transmissionCb.Checked = false;
                oilCb.Checked = false;
                lubeCb.Checked = false;
                partsTb.Text = "";
                hoursTb.Text = "";
                msgparts1Lb.Text = "";
                msgparts2Lb.Text = "";
                serviceSumTb.Text = "";
                laborSumTb.Text = "";
                laborSumTb.BackColor = DefaultBackColor;
                partsSumTb.Text = "";
                gstTb.Text = "";
                pstTb.Text = "";
                totalFeesTb.Text = "";
            }

            //Main form
            private void mainForm_Load(object sender, EventArgs e)
            {
                this.AutoSize = true;
                this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                tiresLb.Visible = false;
            }

            //Calculate button
            private void calcBt_Click(object sender, EventArgs e)
            {
                CalcPartsHours();
                CalcServiceLabor();

                totalFeesTb.Text = (TotalCharges(servLaborTotal, partsTotal) + CalculatePST(partsTotal) + CalculateGST(partsTotal)).ToString("c2");
            }

             //Method to Calculate PST tax
            private double CalculatePST(double calcTaxParts)
            {
                double posTaxPST = calcTaxParts * taxPST;
                pstTb.Text = posTaxPST.ToString("c2");

                return posTaxPST;
            }

            //Method to Calculate GST tax
            private double CalculateGST(double calcTaxGST)
            {
                double posTaxGST = calcTaxGST * taxGST;
                gstTb.Text = posTaxGST.ToString("c2");

                return posTaxGST;
            }

            //Method to Calculate Total Charges without taxes
            private double TotalCharges(double servLabor, double parts)
            {
                double totalNoTax;
                totalNoTax = servLabor + parts;

                return totalNoTax;
            }
        }
    }

