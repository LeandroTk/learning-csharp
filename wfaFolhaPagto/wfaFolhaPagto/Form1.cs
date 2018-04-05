using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaFolhaPagto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double calculateTotalSalary()
        {
            int hours;
            double totalSalary, hourValue;

            hours = int.Parse(workHoursInput.Text);
            hourValue = int.Parse(HourValueInput.Text);
            totalSalary = hours * hourValue;
            return totalSalary;
        }

        double calculateInss()
        {
            double totalSalary;
            totalSalary = calculateTotalSalary();

            if (totalSalary < 965.67)
            {
                return totalSalary * 8 / 100;
            }
            else if (totalSalary < 1069.45)
            {
                return totalSalary * 9 / 100;
            }
            else if (totalSalary < 3218.90)
            {
                return totalSalary * 11 / 100;
            }
            else
            {
                return 354.08;
            }
        }

        double calculateIRDeduction(double baseSalary) {
            if (baseSalary < 1434.59)
            {
                return 0.0;
            }
            else if (baseSalary < 2150.00)
            {
                return baseSalary * 7.5 / 100 - 107.59;
            }
            else if (baseSalary < 2866.70)
            {
                return baseSalary * 15.0 / 100  - 268.84;
            }
            else if (baseSalary < 3582.00)
            {
                return baseSalary * 22.5 / 100 - 483.84;
            }
            else
            {
                return baseSalary * 27.5 / 100 - 662.94;
            }
        }

        double calculateIr()
        {
            int dependentNumber;
            double totalSalary, inss, dependentDiscount, baseSalary;

            dependentNumber = int.Parse(dependentsNumberInput.Text);
            dependentDiscount = dependentNumber * 144.20;
            totalSalary = calculateTotalSalary();

            baseSalary = totalSalary - calculateInss() - dependentDiscount;

            return calculateIRDeduction(baseSalary);
        }

        double calculateLiquidSalary()
        {
            return calculateTotalSalary() - calculateInss() - calculateIr();
        }

        void calculate()
        {
            try {
                txtSalary.Text = calculateTotalSalary().ToString("###,###,##0.00");
                txtInss.Text = calculateInss().ToString("###,###,##0.00");
                txtTax.Text = calculateIr().ToString("###,###,##0.00");
                txtLiquidSalary.Text = calculateLiquidSalary().ToString("###,###,##0.00");
            } catch (Exception caught) {
                MessageBox.Show("Erro: " + caught.Message);
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            calculate();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            nameInput.Text = "";
            workHoursInput.Text = "";
            HourValueInput.Text = "";
            dependentsNumberInput.Text = "";
            txtSalary.Text = "";
            txtInss.Text = "";
            txtTax.Text = "";
            txtLiquidSalary.Text = "";
            nameInput.Focus();
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
