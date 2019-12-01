namespace WindowsFormsApplication13
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCreateStudent = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDelStudent = new System.Windows.Forms.Button();
            this.btnTop3 = new System.Windows.Forms.Button();
            this.btnViewAttendance = new System.Windows.Forms.Button();
            this.panelCreateStudent = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.labelUni = new System.Windows.Forms.Label();
            this.labelDept = new System.Windows.Forms.Label();
            this.labelCGPA = new System.Windows.Forms.Label();
            this.labeSemester = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxUni = new System.Windows.Forms.TextBox();
            this.textBoxDept = new System.Windows.Forms.TextBox();
            this.textBoxCGPA = new System.Windows.Forms.TextBox();
            this.textBoxSemester = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.panelSearchStudent = new System.Windows.Forms.Panel();
            this.data_grid = new System.Windows.Forms.DataGridView();
            this.btnCancelSearch = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.radioButtonListAll = new System.Windows.Forms.RadioButton();
            this.radioButtonSearcbByName = new System.Windows.Forms.RadioButton();
            this.radioButtonSearchByID = new System.Windows.Forms.RadioButton();
            this.panelDelete = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDeleteId = new System.Windows.Forms.Button();
            this.labelDelete = new System.Windows.Forms.Label();
            this.textBoxDeleteStudent = new System.Windows.Forms.TextBox();
            this.panelTop3 = new System.Windows.Forms.Panel();
            this.btnBackTop3 = new System.Windows.Forms.Button();
            this.labelTop3 = new System.Windows.Forms.Label();
            this.gridTop3 = new System.Windows.Forms.DataGridView();
            this.panelViewAttendance = new System.Windows.Forms.Panel();
            this.dataGridViewAttendance = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panelMarkAttendance = new System.Windows.Forms.Panel();
            this.dataGridMarkAttendance = new System.Windows.Forms.DataGridView();
            this.btnMarkAttendanceBack = new System.Windows.Forms.Button();
            this.btnViewFromInside = new System.Windows.Forms.Button();
            this.btnMarkAttendance = new System.Windows.Forms.Button();
            this.panelCreateStudent.SuspendLayout();
            this.panelSearchStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid)).BeginInit();
            this.panelDelete.SuspendLayout();
            this.panelTop3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTop3)).BeginInit();
            this.panelViewAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttendance)).BeginInit();
            this.panelMarkAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMarkAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateStudent
            // 
            this.btnCreateStudent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreateStudent.BackgroundImage")));
            this.btnCreateStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreateStudent.Location = new System.Drawing.Point(66, 28);
            this.btnCreateStudent.Name = "btnCreateStudent";
            this.btnCreateStudent.Size = new System.Drawing.Size(164, 125);
            this.btnCreateStudent.TabIndex = 0;
            this.btnCreateStudent.UseVisualStyleBackColor = true;
            this.btnCreateStudent.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(677, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 125);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDelStudent
            // 
            this.btnDelStudent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelStudent.BackgroundImage")));
            this.btnDelStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelStudent.Location = new System.Drawing.Point(371, 28);
            this.btnDelStudent.Name = "btnDelStudent";
            this.btnDelStudent.Size = new System.Drawing.Size(164, 125);
            this.btnDelStudent.TabIndex = 2;
            this.btnDelStudent.UseVisualStyleBackColor = true;
            this.btnDelStudent.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnTop3
            // 
            this.btnTop3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTop3.BackgroundImage")));
            this.btnTop3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTop3.Location = new System.Drawing.Point(677, 215);
            this.btnTop3.Name = "btnTop3";
            this.btnTop3.Size = new System.Drawing.Size(164, 125);
            this.btnTop3.TabIndex = 3;
            this.btnTop3.UseVisualStyleBackColor = true;
            this.btnTop3.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnViewAttendance
            // 
            this.btnViewAttendance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewAttendance.BackgroundImage")));
            this.btnViewAttendance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewAttendance.Location = new System.Drawing.Point(371, 215);
            this.btnViewAttendance.Name = "btnViewAttendance";
            this.btnViewAttendance.Size = new System.Drawing.Size(164, 125);
            this.btnViewAttendance.TabIndex = 5;
            this.btnViewAttendance.UseVisualStyleBackColor = true;
            this.btnViewAttendance.Click += new System.EventHandler(this.button6_Click);
            // 
            // panelCreateStudent
            // 
            this.panelCreateStudent.Controls.Add(this.button8);
            this.panelCreateStudent.Controls.Add(this.button7);
            this.panelCreateStudent.Controls.Add(this.labelUni);
            this.panelCreateStudent.Controls.Add(this.labelDept);
            this.panelCreateStudent.Controls.Add(this.labelCGPA);
            this.panelCreateStudent.Controls.Add(this.labeSemester);
            this.panelCreateStudent.Controls.Add(this.labelName);
            this.panelCreateStudent.Controls.Add(this.labelID);
            this.panelCreateStudent.Controls.Add(this.textBoxUni);
            this.panelCreateStudent.Controls.Add(this.textBoxDept);
            this.panelCreateStudent.Controls.Add(this.textBoxCGPA);
            this.panelCreateStudent.Controls.Add(this.textBoxSemester);
            this.panelCreateStudent.Controls.Add(this.textBoxName);
            this.panelCreateStudent.Controls.Add(this.textBoxID);
            this.panelCreateStudent.Location = new System.Drawing.Point(921, 12);
            this.panelCreateStudent.Name = "panelCreateStudent";
            this.panelCreateStudent.Size = new System.Drawing.Size(58, 34);
            this.panelCreateStudent.TabIndex = 7;
            this.panelCreateStudent.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(508, 354);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(137, 41);
            this.button8.TabIndex = 13;
            this.button8.Text = "Cancel";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(287, 354);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(145, 41);
            this.button7.TabIndex = 12;
            this.button7.Text = "Save";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // labelUni
            // 
            this.labelUni.AutoSize = true;
            this.labelUni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUni.Location = new System.Drawing.Point(183, 308);
            this.labelUni.Name = "labelUni";
            this.labelUni.Size = new System.Drawing.Size(87, 20);
            this.labelUni.TabIndex = 11;
            this.labelUni.Text = "University";
            // 
            // labelDept
            // 
            this.labelDept.AutoSize = true;
            this.labelDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDept.Location = new System.Drawing.Point(183, 256);
            this.labelDept.Name = "labelDept";
            this.labelDept.Size = new System.Drawing.Size(45, 20);
            this.labelDept.TabIndex = 10;
            this.labelDept.Text = "dept";
            // 
            // labelCGPA
            // 
            this.labelCGPA.AutoSize = true;
            this.labelCGPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCGPA.Location = new System.Drawing.Point(183, 198);
            this.labelCGPA.Name = "labelCGPA";
            this.labelCGPA.Size = new System.Drawing.Size(58, 20);
            this.labelCGPA.TabIndex = 9;
            this.labelCGPA.Text = "CGPA";
            // 
            // labeSemester
            // 
            this.labeSemester.AutoSize = true;
            this.labeSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeSemester.Location = new System.Drawing.Point(183, 143);
            this.labeSemester.Name = "labeSemester";
            this.labeSemester.Size = new System.Drawing.Size(86, 20);
            this.labeSemester.TabIndex = 8;
            this.labeSemester.Text = "Semester";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(183, 93);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(55, 20);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Name";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(183, 41);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(28, 20);
            this.labelID.TabIndex = 6;
            this.labelID.Text = "ID";
            // 
            // textBoxUni
            // 
            this.textBoxUni.Location = new System.Drawing.Point(481, 308);
            this.textBoxUni.Name = "textBoxUni";
            this.textBoxUni.Size = new System.Drawing.Size(214, 20);
            this.textBoxUni.TabIndex = 5;
            // 
            // textBoxDept
            // 
            this.textBoxDept.Location = new System.Drawing.Point(481, 256);
            this.textBoxDept.Name = "textBoxDept";
            this.textBoxDept.Size = new System.Drawing.Size(214, 20);
            this.textBoxDept.TabIndex = 4;
            this.textBoxDept.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBoxCGPA
            // 
            this.textBoxCGPA.Location = new System.Drawing.Point(481, 198);
            this.textBoxCGPA.Name = "textBoxCGPA";
            this.textBoxCGPA.Size = new System.Drawing.Size(214, 20);
            this.textBoxCGPA.TabIndex = 3;
            // 
            // textBoxSemester
            // 
            this.textBoxSemester.Location = new System.Drawing.Point(481, 143);
            this.textBoxSemester.Name = "textBoxSemester";
            this.textBoxSemester.Size = new System.Drawing.Size(214, 20);
            this.textBoxSemester.TabIndex = 2;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(481, 93);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(214, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Location = new System.Drawing.Point(481, 41);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(214, 20);
            this.textBoxID.TabIndex = 0;
            // 
            // panelSearchStudent
            // 
            this.panelSearchStudent.Controls.Add(this.data_grid);
            this.panelSearchStudent.Controls.Add(this.btnCancelSearch);
            this.panelSearchStudent.Controls.Add(this.btnSearch);
            this.panelSearchStudent.Controls.Add(this.searchBox);
            this.panelSearchStudent.Controls.Add(this.labelSearch);
            this.panelSearchStudent.Controls.Add(this.radioButtonListAll);
            this.panelSearchStudent.Controls.Add(this.radioButtonSearcbByName);
            this.panelSearchStudent.Controls.Add(this.radioButtonSearchByID);
            this.panelSearchStudent.Location = new System.Drawing.Point(921, 124);
            this.panelSearchStudent.Name = "panelSearchStudent";
            this.panelSearchStudent.Size = new System.Drawing.Size(65, 51);
            this.panelSearchStudent.TabIndex = 8;
            this.panelSearchStudent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSearchStudent_Paint);
            // 
            // data_grid
            // 
            this.data_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_grid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid.Location = new System.Drawing.Point(13, 282);
            this.data_grid.Name = "data_grid";
            this.data_grid.Size = new System.Drawing.Size(972, 97);
            this.data_grid.TabIndex = 11;
            // 
            // btnCancelSearch
            // 
            this.btnCancelSearch.Location = new System.Drawing.Point(384, 193);
            this.btnCancelSearch.Name = "btnCancelSearch";
            this.btnCancelSearch.Size = new System.Drawing.Size(113, 37);
            this.btnCancelSearch.TabIndex = 7;
            this.btnCancelSearch.Text = "Cancel/Back";
            this.btnCancelSearch.UseVisualStyleBackColor = true;
            this.btnCancelSearch.Click += new System.EventHandler(this.btnCancelSearch_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(245, 193);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(113, 37);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(245, 115);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(167, 20);
            this.searchBox.TabIndex = 5;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(240, 24);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(130, 20);
            this.labelSearch.TabIndex = 4;
            this.labelSearch.Text = "Select 1 option";
            // 
            // radioButtonListAll
            // 
            this.radioButtonListAll.AutoSize = true;
            this.radioButtonListAll.Location = new System.Drawing.Point(511, 71);
            this.radioButtonListAll.Name = "radioButtonListAll";
            this.radioButtonListAll.Size = new System.Drawing.Size(55, 17);
            this.radioButtonListAll.TabIndex = 3;
            this.radioButtonListAll.TabStop = true;
            this.radioButtonListAll.Text = "List All";
            this.radioButtonListAll.UseVisualStyleBackColor = true;
            this.radioButtonListAll.CheckedChanged += new System.EventHandler(this.radioButtonListAll_CheckedChanged);
            // 
            // radioButtonSearcbByName
            // 
            this.radioButtonSearcbByName.AutoSize = true;
            this.radioButtonSearcbByName.Location = new System.Drawing.Point(371, 71);
            this.radioButtonSearcbByName.Name = "radioButtonSearcbByName";
            this.radioButtonSearcbByName.Size = new System.Drawing.Size(105, 17);
            this.radioButtonSearcbByName.TabIndex = 2;
            this.radioButtonSearcbByName.TabStop = true;
            this.radioButtonSearcbByName.Text = "Search By Name";
            this.radioButtonSearcbByName.UseVisualStyleBackColor = true;
            this.radioButtonSearcbByName.CheckedChanged += new System.EventHandler(this.radioButtonSearcbByName_CheckedChanged);
            // 
            // radioButtonSearchByID
            // 
            this.radioButtonSearchByID.AutoSize = true;
            this.radioButtonSearchByID.Location = new System.Drawing.Point(244, 71);
            this.radioButtonSearchByID.Name = "radioButtonSearchByID";
            this.radioButtonSearchByID.Size = new System.Drawing.Size(88, 17);
            this.radioButtonSearchByID.TabIndex = 1;
            this.radioButtonSearchByID.TabStop = true;
            this.radioButtonSearchByID.Text = "Search By ID";
            this.radioButtonSearchByID.UseVisualStyleBackColor = true;
            this.radioButtonSearchByID.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // panelDelete
            // 
            this.panelDelete.Controls.Add(this.btnDelete);
            this.panelDelete.Controls.Add(this.btnDeleteId);
            this.panelDelete.Controls.Add(this.labelDelete);
            this.panelDelete.Controls.Add(this.textBoxDeleteStudent);
            this.panelDelete.Location = new System.Drawing.Point(922, 65);
            this.panelDelete.Name = "panelDelete";
            this.panelDelete.Size = new System.Drawing.Size(58, 44);
            this.panelDelete.TabIndex = 9;
            this.panelDelete.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDelete_Paint);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(242, 191);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(145, 33);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Cancel";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDeleteId
            // 
            this.btnDeleteId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteId.Location = new System.Drawing.Point(70, 191);
            this.btnDeleteId.Name = "btnDeleteId";
            this.btnDeleteId.Size = new System.Drawing.Size(145, 33);
            this.btnDeleteId.TabIndex = 2;
            this.btnDeleteId.Text = "Delete";
            this.btnDeleteId.UseVisualStyleBackColor = true;
            this.btnDeleteId.Click += new System.EventHandler(this.btnDeleteId_Click);
            // 
            // labelDelete
            // 
            this.labelDelete.AutoSize = true;
            this.labelDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDelete.Location = new System.Drawing.Point(70, 78);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(77, 20);
            this.labelDelete.TabIndex = 1;
            this.labelDelete.Text = "Enter ID";
            // 
            // textBoxDeleteStudent
            // 
            this.textBoxDeleteStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDeleteStudent.Location = new System.Drawing.Point(215, 73);
            this.textBoxDeleteStudent.Name = "textBoxDeleteStudent";
            this.textBoxDeleteStudent.Size = new System.Drawing.Size(172, 26);
            this.textBoxDeleteStudent.TabIndex = 0;
            // 
            // panelTop3
            // 
            this.panelTop3.Controls.Add(this.btnBackTop3);
            this.panelTop3.Controls.Add(this.labelTop3);
            this.panelTop3.Controls.Add(this.gridTop3);
            this.panelTop3.Location = new System.Drawing.Point(921, 339);
            this.panelTop3.Name = "panelTop3";
            this.panelTop3.Size = new System.Drawing.Size(65, 46);
            this.panelTop3.TabIndex = 10;
            // 
            // btnBackTop3
            // 
            this.btnBackTop3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackTop3.Location = new System.Drawing.Point(397, 288);
            this.btnBackTop3.Name = "btnBackTop3";
            this.btnBackTop3.Size = new System.Drawing.Size(152, 37);
            this.btnBackTop3.TabIndex = 13;
            this.btnBackTop3.Text = "Back";
            this.btnBackTop3.UseVisualStyleBackColor = true;
            this.btnBackTop3.Click += new System.EventHandler(this.btnBackTop3_Click);
            // 
            // labelTop3
            // 
            this.labelTop3.AutoSize = true;
            this.labelTop3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTop3.Location = new System.Drawing.Point(83, 73);
            this.labelTop3.Name = "labelTop3";
            this.labelTop3.Size = new System.Drawing.Size(151, 24);
            this.labelTop3.TabIndex = 12;
            this.labelTop3.Text = "Top 3 Students";
            // 
            // gridTop3
            // 
            this.gridTop3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTop3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.gridTop3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridTop3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTop3.Location = new System.Drawing.Point(87, 147);
            this.gridTop3.Name = "gridTop3";
            this.gridTop3.Size = new System.Drawing.Size(731, 101);
            this.gridTop3.TabIndex = 11;
            // 
            // panelViewAttendance
            // 
            this.panelViewAttendance.Controls.Add(this.button1);
            this.panelViewAttendance.Controls.Add(this.dataGridViewAttendance);
            this.panelViewAttendance.Location = new System.Drawing.Point(921, 268);
            this.panelViewAttendance.Name = "panelViewAttendance";
            this.panelViewAttendance.Size = new System.Drawing.Size(65, 42);
            this.panelViewAttendance.TabIndex = 11;
            this.panelViewAttendance.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMarkAttendance_Paint);
            // 
            // dataGridViewAttendance
            // 
            this.dataGridViewAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAttendance.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAttendance.Location = new System.Drawing.Point(53, 37);
            this.dataGridViewAttendance.Name = "dataGridViewAttendance";
            this.dataGridViewAttendance.Size = new System.Drawing.Size(824, 150);
            this.dataGridViewAttendance.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(410, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 43);
            this.button1.TabIndex = 12;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panelMarkAttendance
            // 
            this.panelMarkAttendance.Controls.Add(this.btnViewFromInside);
            this.panelMarkAttendance.Controls.Add(this.btnMarkAttendanceBack);
            this.panelMarkAttendance.Controls.Add(this.dataGridMarkAttendance);
            this.panelMarkAttendance.Location = new System.Drawing.Point(922, 195);
            this.panelMarkAttendance.Name = "panelMarkAttendance";
            this.panelMarkAttendance.Size = new System.Drawing.Size(64, 53);
            this.panelMarkAttendance.TabIndex = 13;
            // 
            // dataGridMarkAttendance
            // 
            this.dataGridMarkAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridMarkAttendance.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridMarkAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMarkAttendance.Location = new System.Drawing.Point(22, 36);
            this.dataGridMarkAttendance.Name = "dataGridMarkAttendance";
            this.dataGridMarkAttendance.Size = new System.Drawing.Size(924, 187);
            this.dataGridMarkAttendance.TabIndex = 0;
            this.dataGridMarkAttendance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnMarkAttendanceBack
            // 
            this.btnMarkAttendanceBack.Location = new System.Drawing.Point(397, 242);
            this.btnMarkAttendanceBack.Name = "btnMarkAttendanceBack";
            this.btnMarkAttendanceBack.Size = new System.Drawing.Size(166, 35);
            this.btnMarkAttendanceBack.TabIndex = 1;
            this.btnMarkAttendanceBack.Text = "Back";
            this.btnMarkAttendanceBack.UseVisualStyleBackColor = true;
            this.btnMarkAttendanceBack.Click += new System.EventHandler(this.btnMarkAttendanceBack_Click);
            // 
            // btnViewFromInside
            // 
            this.btnViewFromInside.Location = new System.Drawing.Point(220, 242);
            this.btnViewFromInside.Name = "btnViewFromInside";
            this.btnViewFromInside.Size = new System.Drawing.Size(124, 35);
            this.btnViewFromInside.TabIndex = 2;
            this.btnViewFromInside.Text = "View Attendance";
            this.btnViewFromInside.UseVisualStyleBackColor = true;
            this.btnViewFromInside.Click += new System.EventHandler(this.btnViewFromInside_Click);
            // 
            // btnMarkAttendance
            // 
            this.btnMarkAttendance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMarkAttendance.BackgroundImage")));
            this.btnMarkAttendance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMarkAttendance.Location = new System.Drawing.Point(66, 215);
            this.btnMarkAttendance.Name = "btnMarkAttendance";
            this.btnMarkAttendance.Size = new System.Drawing.Size(164, 125);
            this.btnMarkAttendance.TabIndex = 4;
            this.btnMarkAttendance.UseVisualStyleBackColor = true;
            this.btnMarkAttendance.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1009, 434);
            this.Controls.Add(this.panelMarkAttendance);
            this.Controls.Add(this.panelViewAttendance);
            this.Controls.Add(this.panelTop3);
            this.Controls.Add(this.panelDelete);
            this.Controls.Add(this.panelSearchStudent);
            this.Controls.Add(this.panelCreateStudent);
            this.Controls.Add(this.btnViewAttendance);
            this.Controls.Add(this.btnMarkAttendance);
            this.Controls.Add(this.btnTop3);
            this.Controls.Add(this.btnDelStudent);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCreateStudent);
            this.Name = "Form1";
            this.Text = "Bahria University CMS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelCreateStudent.ResumeLayout(false);
            this.panelCreateStudent.PerformLayout();
            this.panelSearchStudent.ResumeLayout(false);
            this.panelSearchStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid)).EndInit();
            this.panelDelete.ResumeLayout(false);
            this.panelDelete.PerformLayout();
            this.panelTop3.ResumeLayout(false);
            this.panelTop3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTop3)).EndInit();
            this.panelViewAttendance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttendance)).EndInit();
            this.panelMarkAttendance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMarkAttendance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateStudent;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDelStudent;
        private System.Windows.Forms.Button btnTop3;
        private System.Windows.Forms.Button btnViewAttendance;
        private System.Windows.Forms.Panel panelCreateStudent;
        private System.Windows.Forms.TextBox textBoxDept;
        private System.Windows.Forms.TextBox textBoxCGPA;
        private System.Windows.Forms.TextBox textBoxSemester;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelUni;
        private System.Windows.Forms.Label labelDept;
        private System.Windows.Forms.Label labelCGPA;
        private System.Windows.Forms.Label labeSemester;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxUni;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panelSearchStudent;
        private System.Windows.Forms.RadioButton radioButtonSearchByID;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.RadioButton radioButtonListAll;
        private System.Windows.Forms.RadioButton radioButtonSearcbByName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button btnCancelSearch;
        private System.Windows.Forms.Panel panelDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDeleteId;
        private System.Windows.Forms.Label labelDelete;
        private System.Windows.Forms.TextBox textBoxDeleteStudent;
        private System.Windows.Forms.DataGridView data_grid;
        private System.Windows.Forms.Panel panelTop3;
        private System.Windows.Forms.Label labelTop3;
        private System.Windows.Forms.DataGridView gridTop3;
        private System.Windows.Forms.Button btnBackTop3;
        private System.Windows.Forms.Panel panelViewAttendance;
        private System.Windows.Forms.DataGridView dataGridViewAttendance;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelMarkAttendance;
        private System.Windows.Forms.DataGridView dataGridMarkAttendance;
        private System.Windows.Forms.Button btnViewFromInside;
        private System.Windows.Forms.Button btnMarkAttendanceBack;
        private System.Windows.Forms.Button btnMarkAttendance;
    }
}

