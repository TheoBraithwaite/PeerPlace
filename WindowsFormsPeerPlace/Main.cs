using System;
using System.IO;
using System.Security.AccessControl;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPeerPlace
{
    public partial class Main : Form
    {
        DataTable employeeTable = new DataTable();

        List<int> idList = new List<int>();
        List<string> firstNameList = new List<string>();
        List<string> lastNameList = new List<string>();
        List<string> emailList = new List<string>();
        List<int> numberList = new List<int>();
        List<string> genderList = new List<string>();
        List<string> addressList = new List<string>();

        //comboBox selected type
        int typeValue = 0;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            string line = "";
            string[] csvArray;

            comboBoxSearch.Items.AddRange(new string[] {"ID", "First Name", "Last Name", "Email", "Employee ID", "Gender"});
            comboBoxSearch.DropDownStyle = ComboBoxStyle.DropDownList;

            typeValue = comboBoxSearch.SelectedIndex = 0;

            //employeeGrid.Columns.Add("Index", "Index");
            //employeeGrid.Columns.Add("Value", "Dice Value");
            //int[] theData = new int[] { 5, 2, 1, 5, 4, 1, 3, 1 };

            //for (int i = 0; i < theData.Length; i++)
            //{
            //employeeGrid.Rows.Add(new object[] { i + 1, theData[i] });
            //}

            string openLocation = @"C:\Users\BEASTY-BOY\Desktop\PeerPlace\employeeList.csv";
            using var reader = new StreamReader(openLocation);
            {
                int id;
                string firstName;
                string lastName;
                string email;
                int employeeNum;
                string gender;
                string streetAddress;

                while (!reader.EndOfStream)
                {
                    try
                    {
                        //Read a line from the file
                        line = reader.ReadLine();
                        //Split the clients in the line using an array
                        csvArray = line.Split(',');
                        //Check if the array has the correct number of elements
                        if (csvArray.Length == 7)
                        {

                            //Extract the data into separate variables
                            id = int.Parse(csvArray[0]);
                            firstName = csvArray[1];
                            lastName = csvArray[2];
                            email = csvArray[3];
                            employeeNum = int.Parse(csvArray[4]);
                            gender = csvArray[5];
                            streetAddress = csvArray[6];

                            //Add clients to list.
                            idList.Add(id);

                            //Add password to list.
                            firstNameList.Add(firstName);
                            lastNameList.Add(lastName);
                            emailList.Add(email);
                            numberList.Add(employeeNum);
                            genderList.Add(gender);
                        }
                        else
                        {
                            //LabelMethod(errorFile);
                            MessageBox.Show("Error in file.");
                        }
                    }
                    catch
                    {
                        //LabelMethod(errorCrash);
                        MessageBox.Show("Fatal error.");
                    }
                }
                MessageBox.Show("Completed.");

                employeeTable.Columns.Add("ID", typeof(int));
                employeeTable.Columns.Add("First Name", typeof(string));
                employeeTable.Columns.Add("Last Name", typeof(string));
                employeeTable.Columns.Add("Email", typeof(string));
                employeeTable.Columns.Add("Employee ID", typeof(int)) ;
                employeeTable.Columns.Add("Gender", typeof(string));

                for (int i = 0; i < idList.Count; i++)
                {
                    employeeTable.Rows.Add(new object[] { i + 1, firstNameList[i], lastNameList[i], emailList[i], numberList[i], genderList[i] });
                }

                employeeGrid.DataSource = employeeTable;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = textBoxSearch.Text;
            typeValue = comboBoxSearch.SelectedIndex;

            try
            {
                var re = from row in employeeTable.AsEnumerable()
                            where row[typeValue].ToString().Contains(searchValue)
                            select row;

                int results = re.Count();
                labelResults.Text = "Results found: " + results;

                employeeGrid.DataSource = re.CopyToDataTable();
            }
            catch (Exception ex)
            {
                labelResults.Text = ex.Message;
                return;
            }
        }
    }
}
