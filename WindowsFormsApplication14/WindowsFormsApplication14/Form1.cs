using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication13
{
    public partial class Form1 : Form
    {
        Student[] obj = new Student[50];
        string[] data;
        int students;
        string path = "Data.txt";
        List<Student> listObj = new List<Student>();
        public Form1()
        {
            InitializeComponent();
            panelCreateStudent.Hide();
            panelSearchStudent.Hide();
            panelTop3.Hide();
            panelMarkAttendance.Hide();
            panelViewAttendance.Hide();
            panelDelete.Hide();
            ReadFile();
        }
        public void ReadFile()
        {
            int temp;
            string path = "Data.txt";
            //string allData = "";
            data = File.ReadAllLines(path);
            //foreach (string i in data)
            //{
            //    allData = allData + i + "\n";
            //    data_grid.DataSource = i;
            //}
            temp = data.Length;
            students = temp / 7;
            int count = 0;
            listObj.Clear();
            for (int i = 0; i < students && count != temp; i++)
            {

                obj[i] = new Student();
                obj[i].Enrollment = data[count];
                count++;
                obj[i].Name = data[count];
                count++;
                obj[i].Semester = data[count];
                count++;
                obj[i].CGPA = data[count];
                count++;
                obj[i].Department = data[count];
                count++;
                obj[i].University = data[count];
                count++;
                obj[i].Attendance = data[count];
                count++;
                listObj.Add(obj[i]);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            panelCreateStudent.Show();
            panelCreateStudent.Height = 458;
            panelCreateStudent.Width = 915;
            panelCreateStudent.Location = new Point(0, 0);
            if (listObj.Count!=0)
            {
                   Student last = listObj[listObj.Count - 1];
                   textBoxID.Text = (Convert.ToInt32(last.Enrollment) + 1).ToString();
            }
            else
            {
                textBoxID.Text = "1";
            }
            
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            panelSearchStudent.Show();
            panelSearchStudent.Height = 458;
            panelSearchStudent.Width = 915;
            panelSearchStudent.Location = new Point(0, 0);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panelCreateStudent.Hide();
        }

        private void panelSearchStudent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
            panelDelete.Show();
            panelDelete.Height = 458;
            panelDelete.Width = 915;
            panelDelete.Location = new Point(0, 0);
        }

        private void panelDelete_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancelSearch_Click(object sender, EventArgs e)
        {
            panelSearchStudent.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            panelDelete.Hide();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==dataGridMarkAttendance.Columns["Attendance"].Index)
            {
                dataGridMarkAttendance.EndEdit();
                if ((bool) dataGridMarkAttendance.Rows[e.RowIndex].Cells["Attendance"].Value)
                {
                    MessageBox.Show(dataGridMarkAttendance.Rows[e.RowIndex].Cells[1].Value + "Marked Present");
                    
                    File.WriteAllText(path, string.Empty);

                    Student temp =listObj.Find(obj =>obj.Enrollment==dataGridMarkAttendance.Rows[e.RowIndex].Cells[0].Value);
                    listObj.ForEach(obj=>
                        {
                            if (obj.Enrollment==dataGridMarkAttendance.Rows[e.RowIndex].Cells[0].Value)
                            {
                                string attendance="Present";
                                string []attData={obj.Enrollment,obj.Name,obj.Semester,obj.CGPA,obj.Department,obj.University,attendance};
                                File.AppendAllLines(path,attData);
                            }
                            else
                            {
                                string[] attData = { obj.Enrollment, obj.Name, obj.Semester, obj.CGPA, obj.Department, obj.University, obj.Attendance };
                                File.AppendAllLines(path, attData);
                            }
                        }
                        );
                }
            }
            //else if (e.ColumnIndex == dataGridMarkAttendance.Columns["Absent"].Index)
            //{
            //    dataGridMarkAttendance.EndEdit();
            //    if ((bool)dataGridMarkAttendance.Rows[e.RowIndex].Cells["Absent"].Value)
            //    {
            //        MessageBox.Show(dataGridMarkAttendance.Rows[e.RowIndex].Cells[1].Value + " Marked Absent");

            //        File.WriteAllText(path, string.Empty);

            //        Student temp = listObj.Find(obj => obj.Enrollment == dataGridMarkAttendance.Rows[e.RowIndex].Cells[0].Value);
            //        listObj.ForEach(obj =>
            //        {
            //            if (obj.Enrollment == dataGridMarkAttendance.Rows[e.RowIndex].Cells[0].Value)
            //            {
            //                string attendance = "Absent";
            //                string[] attData = { obj.Enrollment, obj.Name, obj.Semester, obj.CGPA, obj.Department, obj.University, attendance };
            //                File.AppendAllLines(path, attData);
            //            }

            //        }
            //            );
            //    }
            //}
        }

        private void button9_Click(object sender, EventArgs e)
        {


        }

        private void radioButtonListAll_CheckedChanged(object sender, EventArgs e)
        {
            ReadFile();
            data_grid.Visible = true;
            data_grid.DataSource = listObj;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ReadFile();
            if (radioButtonSearchByID.Checked == true)
            {
                List<Student> searchObj = new List<Student>();
                string id = searchBox.Text;
                listObj.ForEach(ob =>
                {
                    if (ob.Enrollment == id)
                    {
                        searchObj.Add(ob);
                    }
                });
                if (searchObj.Count == 0)
                {
                    MessageBox.Show("No Record Found");
                }
                else
                {
                    data_grid.Visible = true;
                    data_grid.DataSource = searchObj;
                }

            }
            else if (radioButtonSearcbByName.Checked == true)
            {
                List<Student> searchObj = new List<Student>();
                string name = searchBox.Text;
                listObj.ForEach(ob =>
                {
                    if (ob.Name == name)
                    {
                        searchObj.Add(ob);
                    }
                });
                if (searchObj.Count == 0)
                {
                    MessageBox.Show("No Record Found");
                }
                else
                {
                    data_grid.Visible = true;
                    data_grid.DataSource = searchObj;
                }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            addStudent();
        }
        public void addStudent()
        {
            ReadFile();
            for (int i = 0; i < students; i++)
            {
                if (textBoxID.Text == obj[i].Enrollment)
                {
                    MessageBox.Show("ID already exists, choose another");
                }
            }
            string[] str = {textBoxID.Text, textBoxName.Text, textBoxSemester.Text, textBoxCGPA.Text, textBoxDept.Text, textBoxUni.Text, "Null" };
            File.AppendAllLines(path, str);
            clearTextBox();
            MessageBox.Show("Student Added Successfully");
        }
        public void clearTextBox()
        {
            textBoxID.Clear();
            textBoxName.Clear();
            textBoxUni.Clear();
            textBoxSemester.Clear(); ;
            textBoxCGPA.Clear();
            textBoxDept.Clear();
        }
        public void deleteStudent()
        {
            ReadFile();
            string delete = textBoxDeleteStudent.Text;
            File.WriteAllText(path, String.Empty);
            for (int i = 0; i < students; i++)
            {
                if (obj[i].Enrollment != delete)
                {
                    string[] updates = {obj[i].Enrollment, obj[i].Name, obj[i].Semester, obj[i].CGPA, obj[i].Department, obj[i].University, obj[i].Attendance };
                    File.AppendAllLines(path, updates);
                   // MessageBox.Show("No student found!");
                }
                else
                {
                    MessageBox.Show("Student deleted Successfully");
                }

            }
        }
        public void topThree()
    {
        ReadFile();
        List<Student> topThree = new List<Student>();
        gridTop3.Visible = true;
        int i, j;
        if (students >= 2)
        {
            for (i = 0; i < students; i++)
            {
                for (j = 0; j < students - 1; j++)
                {
                    
                    if ((float)Convert.ToDouble(obj[j].CGPA) < (float)Convert.ToDouble(obj[j + 1].CGPA))
                    {
                       
                        Student temperory = new Student();
                        temperory = obj[j];
                        obj[j] = obj[j + 1];
                        obj[j + 1] = temperory;
                    }
                }
            }
        }
            else
        {
            topThree.Add(obj[0]);
        }
            for (int f=0;f<3;f++)
            {
                topThree.Add(obj[f]);
            }
            gridTop3.DataSource = topThree;
            var buttonCol = new DataGridBoolColumn();
           //buttonCol.Name = "markAttendance";
           //buttonCol.HeaderText = "Attendance";
            //buttonCol.Text = "Present";
           // gridTop3.Columns.Add(buttonCol);
    }

        private void btnDeleteId_Click(object sender, EventArgs e)
    {
        deleteStudent();
    }

     
        private void button4_Click(object sender, EventArgs e)
    {
        panelTop3.Show();
        panelTop3.Height = 458;
        panelTop3.Width = 915;
        panelTop3.Location = new Point(0, 0);
        topThree();
    }

        private void btnBackTop3_Click(object sender, EventArgs e)
    {
        panelTop3.Hide();
    }

        private void button5_Click(object sender, EventArgs e)
    {
        markAttendance();
    }
        public void markAttendance()
        {
            panelMarkAttendance.Show();
            panelMarkAttendance.Height = 458;
            panelMarkAttendance.Width = 915;
            panelMarkAttendance.Location = new Point(0, 0);
            DataTable tableObj = new DataTable();
            tableObj.Columns.Add("ID", typeof(string));
            tableObj.Columns.Add("Name", typeof(string));
            tableObj.Columns.Add("Attendance", System.Type.GetType("System.Boolean"));
            //tableObj.Columns.Add("Absent", System.Type.GetType("System.Boolean"));
            listObj.ForEach(obj =>
                {
                    DataRow temperoryRow = tableObj.NewRow();
                    temperoryRow[0] = obj.Enrollment;
                    temperoryRow[1] = obj.Name;
                    temperoryRow[2] = false;
                    //temperoryRow[3] = false;
                    tableObj.Rows.Add(temperoryRow);
                });
            dataGridMarkAttendance.DataSource = tableObj;
    }
        public void viewAttendance()
    {
        ReadFile();
        panelViewAttendance.Show();
        panelViewAttendance.Height = 458;
        panelViewAttendance.Width = 915;
        panelViewAttendance.Location = new Point(0, 0);
        dataGridViewAttendance.Show();
        dataGridViewAttendance.DataSource=listObj;
        dataGridViewAttendance.AutoGenerateColumns = false;
        dataGridViewAttendance.Columns["Semester"].Visible = false;
        dataGridViewAttendance.Columns["Department"].Visible = false;
        dataGridViewAttendance.Columns["CGPA"].Visible = false;
        dataGridViewAttendance.Columns["University"].Visible = false;

    }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelMarkAttendance_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButtonSearcbByName_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            viewAttendance();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panelViewAttendance.Visible = false;
        }

        private void btnMarkAttendanceBack_Click(object sender, EventArgs e)
        {
            panelMarkAttendance.Hide();
        }

        private void btnViewFromInside_Click(object sender, EventArgs e)
        {
            panelMarkAttendance.Hide();
            viewAttendance();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }
    }
}
