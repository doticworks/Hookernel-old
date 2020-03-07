/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2019/12/14
 * 时间: 19:49
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace Hookernel
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox titlepic;
		private System.Windows.Forms.Label inflabel1;
		private System.Windows.Forms.Label inflabel2;
		private System.Windows.Forms.Label inflable3;
		private System.Windows.Forms.Button taskbut3;
		private System.Windows.Forms.Button taskbut2;
		private System.Windows.Forms.Button taskbut1;
		private System.Windows.Forms.Label Constlab1;
		private System.Windows.Forms.Button startbut;
		private System.Windows.Forms.ListBox proclist;
		private System.Windows.Forms.Label procchoosed;
		private System.Windows.Forms.Label Constlab2;
		private System.Windows.Forms.Label dllpath;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button setdll;
		private System.Windows.Forms.Label tip;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Timer worktimer;
		private System.Windows.Forms.Button injectbut;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.TextBox searchproc;
		private System.Windows.Forms.Button searchbut;
		private System.Windows.Forms.Label searchshow;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.taskbut3 = new System.Windows.Forms.Button();
			this.taskbut2 = new System.Windows.Forms.Button();
			this.taskbut1 = new System.Windows.Forms.Button();
			this.titlepic = new System.Windows.Forms.PictureBox();
			this.inflabel1 = new System.Windows.Forms.Label();
			this.inflabel2 = new System.Windows.Forms.Label();
			this.inflable3 = new System.Windows.Forms.Label();
			this.Constlab1 = new System.Windows.Forms.Label();
			this.startbut = new System.Windows.Forms.Button();
			this.proclist = new System.Windows.Forms.ListBox();
			this.procchoosed = new System.Windows.Forms.Label();
			this.Constlab2 = new System.Windows.Forms.Label();
			this.dllpath = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.setdll = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.searchshow = new System.Windows.Forms.Label();
			this.searchbut = new System.Windows.Forms.Button();
			this.searchproc = new System.Windows.Forms.TextBox();
			this.tip = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.panel4 = new System.Windows.Forms.Panel();
			this.worktimer = new System.Windows.Forms.Timer(this.components);
			this.injectbut = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.titlepic)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.taskbut3);
			this.panel1.Controls.Add(this.taskbut2);
			this.panel1.Controls.Add(this.taskbut1);
			this.panel1.Location = new System.Drawing.Point(0, 80);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 20);
			this.panel1.TabIndex = 0;
			// 
			// taskbut3
			// 
			this.taskbut3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.taskbut3.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.taskbut3.ForeColor = System.Drawing.Color.Aqua;
			this.taskbut3.Location = new System.Drawing.Point(160, 0);
			this.taskbut3.Name = "taskbut3";
			this.taskbut3.Size = new System.Drawing.Size(80, 20);
			this.taskbut3.TabIndex = 2;
			this.taskbut3.Text = "Task3";
			this.taskbut3.UseVisualStyleBackColor = true;
			this.taskbut3.Click += new System.EventHandler(this.Taskbut3Click);
			// 
			// taskbut2
			// 
			this.taskbut2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.taskbut2.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.taskbut2.ForeColor = System.Drawing.Color.Aqua;
			this.taskbut2.Location = new System.Drawing.Point(80, 0);
			this.taskbut2.Name = "taskbut2";
			this.taskbut2.Size = new System.Drawing.Size(80, 20);
			this.taskbut2.TabIndex = 1;
			this.taskbut2.Text = "Task2";
			this.taskbut2.UseVisualStyleBackColor = true;
			this.taskbut2.Click += new System.EventHandler(this.Taskbut2Click);
			// 
			// taskbut1
			// 
			this.taskbut1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.taskbut1.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.taskbut1.ForeColor = System.Drawing.Color.Aqua;
			this.taskbut1.Location = new System.Drawing.Point(0, 0);
			this.taskbut1.Name = "taskbut1";
			this.taskbut1.Size = new System.Drawing.Size(80, 20);
			this.taskbut1.TabIndex = 0;
			this.taskbut1.Text = "Task1";
			this.taskbut1.UseVisualStyleBackColor = true;
			this.taskbut1.Click += new System.EventHandler(this.Taskbut1Click);
			// 
			// titlepic
			// 
			this.titlepic.BackColor = System.Drawing.Color.Transparent;
			this.titlepic.Location = new System.Drawing.Point(0, 0);
			this.titlepic.Name = "titlepic";
			this.titlepic.Size = new System.Drawing.Size(240, 80);
			this.titlepic.TabIndex = 1;
			this.titlepic.TabStop = false;
			// 
			// inflabel1
			// 
			this.inflabel1.BackColor = System.Drawing.Color.Transparent;
			this.inflabel1.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inflabel1.ForeColor = System.Drawing.Color.Yellow;
			this.inflabel1.Location = new System.Drawing.Point(248, 8);
			this.inflabel1.Name = "inflabel1";
			this.inflabel1.Size = new System.Drawing.Size(281, 15);
			this.inflabel1.TabIndex = 2;
			this.inflabel1.Text = "Hookernel                Ver.1.0 Ui     RELEASE";
			// 
			// inflabel2
			// 
			this.inflabel2.BackColor = System.Drawing.Color.Transparent;
			this.inflabel2.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inflabel2.ForeColor = System.Drawing.Color.Yellow;
			this.inflabel2.Location = new System.Drawing.Point(248, 25);
			this.inflabel2.Name = "inflabel2";
			this.inflabel2.Size = new System.Drawing.Size(281, 18);
			this.inflabel2.TabIndex = 3;
			this.inflabel2.Text = "Copyright  P  Tclauncher  At  2019";
			// 
			// inflable3
			// 
			this.inflable3.BackColor = System.Drawing.Color.Transparent;
			this.inflable3.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inflable3.ForeColor = System.Drawing.Color.Yellow;
			this.inflable3.Location = new System.Drawing.Point(250, 43);
			this.inflable3.Name = "inflable3";
			this.inflable3.Size = new System.Drawing.Size(280, 23);
			this.inflable3.TabIndex = 4;
			this.inflable3.Text = "_________________________________________________________________________________" +
	"_______________ ";
			// 
			// Constlab1
			// 
			this.Constlab1.BackColor = System.Drawing.Color.Transparent;
			this.Constlab1.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Constlab1.ForeColor = System.Drawing.Color.Aqua;
			this.Constlab1.Location = new System.Drawing.Point(0, 0);
			this.Constlab1.Name = "Constlab1";
			this.Constlab1.Size = new System.Drawing.Size(380, 20);
			this.Constlab1.TabIndex = 5;
			this.Constlab1.Text = "Choose Process :";
			this.Constlab1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// startbut
			// 
			this.startbut.BackColor = System.Drawing.Color.Transparent;
			this.startbut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.startbut.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.startbut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.startbut.Location = new System.Drawing.Point(380, 0);
			this.startbut.Name = "startbut";
			this.startbut.Size = new System.Drawing.Size(138, 20);
			this.startbut.TabIndex = 7;
			this.startbut.Text = "Start";
			this.startbut.UseVisualStyleBackColor = false;
			this.startbut.Click += new System.EventHandler(this.GetprocbutClick);
			// 
			// proclist
			// 
			this.proclist.BackColor = System.Drawing.Color.LightGray;
			this.proclist.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.proclist.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.proclist.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.proclist.FormattingEnabled = true;
			this.proclist.ItemHeight = 15;
			this.proclist.Location = new System.Drawing.Point(0, 40);
			this.proclist.Name = "proclist";
			this.proclist.Size = new System.Drawing.Size(520, 225);
			this.proclist.TabIndex = 8;
			this.proclist.Visible = false;
			this.proclist.SelectedIndexChanged += new System.EventHandler(this.ProclistSelectedIndexChanged);
			this.proclist.DoubleClick += new System.EventHandler(this.ProclistDoubleClick);
			this.proclist.MouseEnter += new System.EventHandler(this.ProclistMouseEnter);
			this.proclist.MouseLeave += new System.EventHandler(this.ProclistMouseLeave);
			// 
			// procchoosed
			// 
			this.procchoosed.BackColor = System.Drawing.Color.Transparent;
			this.procchoosed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.procchoosed.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.procchoosed.ForeColor = System.Drawing.Color.Aqua;
			this.procchoosed.Location = new System.Drawing.Point(0, 20);
			this.procchoosed.Name = "procchoosed";
			this.procchoosed.Size = new System.Drawing.Size(180, 20);
			this.procchoosed.TabIndex = 9;
			this.procchoosed.Text = "unchoose";
			this.procchoosed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Constlab2
			// 
			this.Constlab2.AllowDrop = true;
			this.Constlab2.BackColor = System.Drawing.Color.Transparent;
			this.Constlab2.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Constlab2.ForeColor = System.Drawing.Color.Aqua;
			this.Constlab2.Location = new System.Drawing.Point(0, 0);
			this.Constlab2.Name = "Constlab2";
			this.Constlab2.Size = new System.Drawing.Size(430, 20);
			this.Constlab2.TabIndex = 10;
			this.Constlab2.Text = "Dll file";
			this.Constlab2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Constlab2.DragDrop += new System.Windows.Forms.DragEventHandler(this.Constlab2DragDrop);
			this.Constlab2.DragEnter += new System.Windows.Forms.DragEventHandler(this.Constlab2DragEnter);
			// 
			// dllpath
			// 
			this.dllpath.AllowDrop = true;
			this.dllpath.BackColor = System.Drawing.Color.Transparent;
			this.dllpath.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dllpath.ForeColor = System.Drawing.Color.Aqua;
			this.dllpath.Location = new System.Drawing.Point(0, 25);
			this.dllpath.Name = "dllpath";
			this.dllpath.Size = new System.Drawing.Size(430, 23);
			this.dllpath.TabIndex = 11;
			this.dllpath.Text = "dll path Unchoosed";
			this.dllpath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.dllpath.Click += new System.EventHandler(this.DllpathClick);
			this.dllpath.DragDrop += new System.Windows.Forms.DragEventHandler(this.Label1DragDrop);
			this.dllpath.DragEnter += new System.Windows.Forms.DragEventHandler(this.Label1DragEnter);
			// 
			// panel2
			// 
			this.panel2.AllowDrop = true;
			this.panel2.BackColor = System.Drawing.Color.Transparent;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.setdll);
			this.panel2.Controls.Add(this.Constlab2);
			this.panel2.Controls.Add(this.dllpath);
			this.panel2.Location = new System.Drawing.Point(10, 380);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(520, 50);
			this.panel2.TabIndex = 12;
			this.panel2.DragDrop += new System.Windows.Forms.DragEventHandler(this.Panel2DragDrop);
			this.panel2.DragEnter += new System.Windows.Forms.DragEventHandler(this.Panel2DragEnter);
			// 
			// setdll
			// 
			this.setdll.AllowDrop = true;
			this.setdll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.setdll.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.setdll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.setdll.Location = new System.Drawing.Point(430, 0);
			this.setdll.Name = "setdll";
			this.setdll.Size = new System.Drawing.Size(88, 48);
			this.setdll.TabIndex = 12;
			this.setdll.Text = "Choose";
			this.setdll.UseVisualStyleBackColor = true;
			this.setdll.Click += new System.EventHandler(this.SetdllClick);
			this.setdll.DragDrop += new System.Windows.Forms.DragEventHandler(this.SetdllDragDrop);
			this.setdll.DragEnter += new System.Windows.Forms.DragEventHandler(this.SetdllDragEnter);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Transparent;
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.searchshow);
			this.panel3.Controls.Add(this.searchbut);
			this.panel3.Controls.Add(this.searchproc);
			this.panel3.Controls.Add(this.Constlab1);
			this.panel3.Controls.Add(this.procchoosed);
			this.panel3.Controls.Add(this.proclist);
			this.panel3.Controls.Add(this.startbut);
			this.panel3.ForeColor = System.Drawing.SystemColors.Control;
			this.panel3.Location = new System.Drawing.Point(10, 105);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(520, 265);
			this.panel3.TabIndex = 13;
			// 
			// searchshow
			// 
			this.searchshow.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.searchshow.ForeColor = System.Drawing.Color.Aqua;
			this.searchshow.Location = new System.Drawing.Point(180, 20);
			this.searchshow.Name = "searchshow";
			this.searchshow.Size = new System.Drawing.Size(177, 20);
			this.searchshow.TabIndex = 12;
			this.searchshow.Text = "label1";
			// 
			// searchbut
			// 
			this.searchbut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.searchbut.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.searchbut.ForeColor = System.Drawing.Color.LightCoral;
			this.searchbut.Location = new System.Drawing.Point(380, 20);
			this.searchbut.Name = "searchbut";
			this.searchbut.Size = new System.Drawing.Size(138, 20);
			this.searchbut.TabIndex = 11;
			this.searchbut.Text = "Search";
			this.searchbut.UseVisualStyleBackColor = true;
			this.searchbut.Click += new System.EventHandler(this.SearchbutClick);
			// 
			// searchproc
			// 
			this.searchproc.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.searchproc.ForeColor = System.Drawing.Color.Blue;
			this.searchproc.Location = new System.Drawing.Point(180, 19);
			this.searchproc.Name = "searchproc";
			this.searchproc.Size = new System.Drawing.Size(200, 23);
			this.searchproc.TabIndex = 10;
			this.searchproc.Text = "Search...";
			this.searchproc.Visible = false;
			this.searchproc.TextChanged += new System.EventHandler(this.SearchprocTextChanged);
			this.searchproc.Leave += new System.EventHandler(this.SearchprocLeave);
			// 
			// tip
			// 
			this.tip.BackColor = System.Drawing.Color.Transparent;
			this.tip.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.tip.Location = new System.Drawing.Point(3, 0);
			this.tip.Name = "tip";
			this.tip.Size = new System.Drawing.Size(575, 20);
			this.tip.TabIndex = 14;
			this.tip.Text = "Ready";
			this.tip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// progressBar1
			// 
			this.progressBar1.BackColor = System.Drawing.Color.Gray;
			this.progressBar1.ForeColor = System.Drawing.Color.Aqua;
			this.progressBar1.Location = new System.Drawing.Point(598, 0);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(185, 20);
			this.progressBar1.TabIndex = 15;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.Transparent;
			this.panel4.Controls.Add(this.tip);
			this.panel4.Controls.Add(this.progressBar1);
			this.panel4.Location = new System.Drawing.Point(0, 442);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(800, 20);
			this.panel4.TabIndex = 16;
			// 
			// worktimer
			// 
			this.worktimer.Enabled = true;
			this.worktimer.Tick += new System.EventHandler(this.WorktimerTick);
			// 
			// injectbut
			// 
			this.injectbut.BackColor = System.Drawing.Color.Transparent;
			this.injectbut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.injectbut.Font = new System.Drawing.Font("Segoe UI Symbol", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.injectbut.ForeColor = System.Drawing.Color.Lime;
			this.injectbut.Location = new System.Drawing.Point(537, 331);
			this.injectbut.Name = "injectbut";
			this.injectbut.Size = new System.Drawing.Size(235, 100);
			this.injectbut.TabIndex = 17;
			this.injectbut.Text = "INJECT";
			this.injectbut.UseVisualStyleBackColor = false;
			this.injectbut.Click += new System.EventHandler(this.InjectbutClick);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Filter = "(*.dll)|*.dll";
			this.openFileDialog1.Multiselect = true;
			this.openFileDialog1.Title = "Choose...";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(784, 462);
			this.Controls.Add(this.injectbut);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.inflable3);
			this.Controls.Add(this.inflabel2);
			this.Controls.Add(this.inflabel1);
			this.Controls.Add(this.titlepic);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Opacity = 0.9D;
			this.Text = "Hookernel";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.titlepic)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
