using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asm2.pro
{
    public partial class Calculate : Form
    {
        static List<Account> accountsList = new List<Account>();
        public Calculate()
        {
            InitializeComponent();
        }

        private void Calculate_Load(object sender, EventArgs e)
        {
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            int formWidth = this.Width;
            int formHeight = this.Height;

            int left = (screenWidth - formWidth) / 2;
            int top = (screenHeight - formHeight) / 2;

            // set the form's location to center screen
            this.Location = new Point(left, top);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            LoadDataGridView();
            dataCus.CellClick += dataCus_CellContentClick;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter your name!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbName.Focus();
                return;
            }

            string ID = tbID.Text;
            if (string.IsNullOrEmpty(ID))
            {
                MessageBox.Show("Please enter your ID!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbID.Focus();
                return;
            }

            if (!double.TryParse(tbLM.Text, out double LMW))
            {
                MessageBox.Show("Please re-enter last month's water number!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!double.TryParse(tbTM.Text, out double TMW))
            {
                MessageBox.Show("Please re-enter this month's water number!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (TMW < LMW)
            {
                MessageBox.Show("Error. This month's water number is larger than last month's water number!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }



            Account acc = new Account();
            acc.Name = name;
            acc.ID = ID;
            acc.LastMonthWater = LMW;
            acc.ThisMonthWater = TMW;
            acc.Consumed = TMW - LMW;

            double consumed = TMW - LMW;

            double Family_1 = 5.973;
            double Family_2 = 7.052;
            double Family_3 = 8.699;
            double Family_4 = 15.929;
            double PRICE_AGENCIES = 9.955;
            double PRICE_PRODUCTION = 11.615;
            double PRICE_BUSINESS = 22.068;

            // Choose type of customer
            string TypeCustomer = null;
            if (cbbtype.SelectedIndex == 0)
            {
                TypeCustomer = "House Hold";

            }
            else if (cbbtype.SelectedIndex == 1)
            {
                TypeCustomer = "Administrative and public services";
            }
            else if (cbbtype.SelectedIndex == 2)
            {
                TypeCustomer = "Production units";
            }
            else if (cbbtype.SelectedIndex == 3)
            {
                TypeCustomer = "Business services";
            }


            if (cbbtype.SelectedIndex == 0)
            {
                tbPeople.ReadOnly = true;
            }
            else
            {
                tbPeople.ReadOnly = false;
            }


            double price = 0;
            switch (TypeCustomer)
            {
                case "House Hold":
                    acc.TypeCustomer = "House Hold";
                    if (consumed <= 10)
                    {
                        price = consumed * Family_1;
                    }
                    else if (consumed <= 20)
                    {
                        price = (10 * Family_1) + (consumed - 10) * Family_2; ;
                    }
                    else if (consumed <= 30)
                    {
                        price = (10 * Family_1) + (10 * Family_2) + (consumed - 20) * Family_3;
                    }
                    else
                    {
                        price = (10 * Family_1) + (10 * Family_2) + (10 * Family_3) + (consumed - 30) * Family_4;
                    }
                    break;

                case "Administrative and public services":
                    acc.TypeCustomer = " Administrative and public services";
                    price = consumed * PRICE_AGENCIES;
                    break;

                case "Production units":
                    acc.TypeCustomer = " Production units";
                    price = consumed * PRICE_PRODUCTION;
                    break;

                case "Business services":
                    acc.TypeCustomer = "Business services";
                    price = consumed * PRICE_BUSINESS;
                    break;


            }
            double environmentFee = price * 0.1;
            double VAT = (price + environmentFee) * 0.1;
            acc.TotalBill = price + environmentFee + VAT;

            double Total = price + environmentFee + VAT;
            tbConsumed.Text = consumed.ToString();
            tbTotal.Text = Total.ToString();

            accountsList.Add(acc);

            dataCus.DataSource = null;
            dataCus.DataSource = accountsList;


            ClearForm();

        }

        private void ClearForm()
        {
            tbName.Text = null;
            tbID.Text = null;
            tbLM.Text = null;
            tbTM.Text = null;
            cbbtype.Text = null;
            tbTotal.Text = null;
            tbConsumed.Text = null;
            tbPeople.Text = null;
        }

        private void dataCus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {

                return;// check if valid cell was clicked
            }

            DataGridViewRow row = dataCus.Rows[e.RowIndex];
            // access the value of the clicked cell
            //object cellValue = clickedCell.Value;
            string ID = row.Cells[0].Value?.ToString() ?? string.Empty;
            string name = row.Cells[1].Value?.ToString() ?? string.Empty;
            string LMW = row.Cells[2].Value?.ToString() ?? string.Empty;
            string TMW = row.Cells[3].Value?.ToString() ?? string.Empty;
            string TypeCustomer = row.Cells[4].Value?.ToString() ?? string.Empty;
            string Consumed = row.Cells[5].Value?.ToString() ?? string.Empty;
            string TotalBill = row.Cells[6].Value?.ToString() ?? string.Empty;


        }


        private void LoadDataGridView()
        {

            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.HeaderText = "ID";
            column1.Name = "ID";

            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.HeaderText = "Name";
            column2.Name = "Name";

            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            column3.HeaderText = "LastMonthWater";
            column3.Name = "LastMonthWater";

            DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
            column4.HeaderText = "ThisMonthWater";
            column4.Name = "ThisMonthWater";

            DataGridViewTextBoxColumn column5 = new DataGridViewTextBoxColumn();
            column5.HeaderText = "TypeCustomer";
            column5.Name = "TypeCustomer";

            DataGridViewTextBoxColumn column6 = new DataGridViewTextBoxColumn();
            column6.HeaderText = "Consumed";
            column6.Name = "Consumed";

            DataGridViewTextBoxColumn column7 = new DataGridViewTextBoxColumn();
            column7.HeaderText = "TotalBill";
            column7.Name = "TotalBill";

            if (dataCus != null)
            {
                dataCus.Columns.Add(column1);
                dataCus.Columns.Add(column2);
                dataCus.Columns.Add(column3);
                dataCus.Columns.Add(column4);
                dataCus.Columns.Add(column5);
                dataCus.Columns.Add(column6);
                dataCus.Columns.Add(column7);

                if (dataCus.Columns["ID"] != null) dataCus.Columns["ID"].DataPropertyName = "ID";
                if (dataCus.Columns["Name"] != null) dataCus.Columns["Name"].DataPropertyName = "Name";
                if (dataCus.Columns["LastMonthWater"] != null) dataCus.Columns["LastMonthWater"].DataPropertyName = "LastMonthWater";
                if (dataCus.Columns["ThisMonthWater"] != null) dataCus.Columns["ThisMonthWater"].DataPropertyName = "ThisMonthWater";
                if (dataCus.Columns["TypeCustomer"] != null) dataCus.Columns["TypeCustomer"].DataPropertyName = "TypeCustomer";
                if (dataCus.Columns["Consumed"] != null) dataCus.Columns["Consumed"].DataPropertyName = "Consumed";
                if (dataCus.Columns["TotalBill"] != null) dataCus.Columns["TotalBill"].DataPropertyName = "TotalBill";

                dataCus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                foreach (DataGridViewColumn column in dataCus.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }


            else
            {
                MessageBox.Show("DataGridView Is null", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter your name!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbName.Focus();
                return;
            }

            string ID = tbID.Text;
            if (string.IsNullOrEmpty(ID))
            {
                MessageBox.Show("Please enter your ID!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbID.Focus();
                return;
            }

            if (!double.TryParse(tbLM.Text, out double LMW))
            {
                MessageBox.Show("Please re-enter last month's water number!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!double.TryParse(tbTM.Text, out double TMW))
            {
                MessageBox.Show("Please re-enter this month's water number!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (TMW < LMW)
            {
                MessageBox.Show("Error. This month's water number is larger than last month's water number!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string TypeCustomer = null;
            if (cbbtype.SelectedIndex == 0)
            {
                TypeCustomer = "House Hold";

            }
            else if (cbbtype.SelectedIndex == 1)
            {
                TypeCustomer = "Administrative and public services";
            }
            else if (cbbtype.SelectedIndex == 2)
            {
                TypeCustomer = "Production units";
            }
            else if (cbbtype.SelectedIndex == 3)
            {
                TypeCustomer = "Business services";
            }
            else
            {
                MessageBox.Show("Please choose type customer", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (cbbtype.SelectedIndex == 0)
            {
                tbPeople.ReadOnly = true;
            }
            else
            {
                tbPeople.ReadOnly = false;
            }


            Account acc = new Account();
            acc.Name = name;
            acc.ID = ID;
            acc.LastMonthWater = LMW;
            acc.ThisMonthWater = TMW;
            acc.Consumed = TMW - LMW;

            double consumed = TMW - LMW;

            double Family_1 = 5.973;
            double Family_2 = 7.052;
            double Family_3 = 8.699;
            double Family_4 = 15.929;
            double PRICE_AGENCIES = 9.955;
            double PRICE_PRODUCTION = 11.615;
            double PRICE_BUSINESS = 22.068;

            double price = 0;
            switch (TypeCustomer)
            {
                case "House Hold":
                    acc.TypeCustomer = "House Hold";
                    if (consumed <= 10)
                    {
                        price = consumed * Family_1;
                    }
                    else if (consumed <= 20)
                    {
                        price = (10 * Family_1) + (consumed - 10) * Family_2; ;
                    }
                    else if (consumed <= 30)
                    {
                        price = (10 * Family_1) + (10 * Family_2) + (consumed - 20) * Family_3;
                    }
                    else
                    {
                        price = (10 * Family_1) + (10 * Family_2) + (10 * Family_3) + (consumed - 30) * Family_4;
                    }
                    break;

                case "Administrative and public services":
                    acc.TypeCustomer = " Administrative and public services";
                    price = consumed * PRICE_AGENCIES;
                    break;

                case "Production units":
                    acc.TypeCustomer = " Production units";
                    price = consumed * PRICE_PRODUCTION;
                    break;

                case "Business services":
                    acc.TypeCustomer = "Business services";
                    price = consumed * PRICE_BUSINESS;
                    break;


            }
            double environmentFee = price * 0.1;
            double VAT = (price + environmentFee) * 0.1;
            acc.TotalBill = price + environmentFee + VAT;

            int selectedIndex = dataCus.CurrentCell.RowIndex;
            if (selectedIndex >= 0 && selectedIndex < accountsList.Count)
            {
                accountsList[selectedIndex] = acc;
                dataCus.DataSource = null;
                dataCus.DataSource = accountsList;
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataCus.CurrentCell.RowIndex;

            if (selectedIndex >= 0 && selectedIndex < accountsList.Count)
            {

                accountsList.RemoveAt(selectedIndex);
                dataCus.DataSource = null;
                dataCus.DataSource = accountsList;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string searchName = tbSearch.Text;
            List<Account> searchResult = accountsList.Where(account => account.Name.ToLower().Contains(searchName)).ToList();
            dataCus.DataSource = null;
            dataCus.DataSource = searchResult;
        }

        private void cbbtype_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbbtype.Text == "House Hold")
            {
                tbPeople.ReadOnly = false;
            }
            else
            {
                tbPeople.ReadOnly = true;
            }

        }

        private void tbPeople_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Do you want to exit?", "Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (confirm == DialogResult.OK)
            {
                Form1 Form1 = new Form1();
                Form1.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Continue...");
            }
        }
    }
}
