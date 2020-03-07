/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2019/12/14
 * 时间: 19:49
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using System.ComponentModel;
using System.Data;
using System.Resources;
using System.Text;
using  System.Collections; 
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;	


namespace Hookernel
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
	
		public  struct taskinfo{
			public int working;
			public int ok1;
			public int procchoint;
			public int baseaddress;
			public int temp;
			public int hack;
			public int yan;
			public string dllname;
			public string searchname;
			public int dlllength;
			public Process[] pname;
			public Process name;
		}
		static taskinfo[] tasklist=new taskinfo[3];
		int nowtask=1;
		int chooseing=0;
		Thread[] getproc=new Thread[3];
		int searchstate=0;  //  0 no   1 type    2 search
		
		
		
		
		
		
		
		
		
		public void getprocfun(int tasknum)
		{
		//	MessageBox.Show(tasknum.ToString());
			while(true)
			{
				if((tasklist[tasknum].working==1))
				{
					if(chooseing==0)
					{
						Thread.Sleep(1000);
						tasklist[tasknum].pname=Process.GetProcesses();
					
							proclist.Items.Clear();
					
					
		//				proclist.Items.AddRange((object[])tasklist[nowtask].pname.ToString());
		
						foreach(Process showname in tasklist[nowtask].pname)
						{
							if(searchstate==2)
							{
								if(showname.ProcessName.Contains(tasklist[tasknum].searchname))
								{
									proclist.Items.Add((object)showname.ProcessName);
								}
							}
							else
							{
								proclist.Items.Add((object)showname.ProcessName);
							}
							
							
						}  
					}
				}
				else 
				{
					
					return;
				}
				
			}
		}
		
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormPaint(object sender, PaintEventArgs e)
		{
			
		}
		void Taskbut1Click(object sender, EventArgs e)
		{
			nowtask=0;
			
		}
		void Taskbut2Click(object sender, EventArgs e)
		{
			nowtask=1;
		}
		void Taskbut3Click(object sender, EventArgs e)
		{
			nowtask=2;
		}
		void GetprocbutClick(object sender, EventArgs e)
		{
			if(tasklist[nowtask].working == 1)
			{
	//			if(proclistbuf!=null)
	//			{
	//				proclist.DataSource=proclistbuf;
	//			}
				
				tasklist[nowtask].working= 0;
			}
			else
			{
	//			if(proclistbuf!=null)
	//			{
	//				proclist.DataSource=null;
	//			}
				
				getproc[nowtask]=new Thread( () => getprocfun(nowtask));
				getproc[nowtask].Start();
				tasklist[nowtask].working=1;
			}
		}
		
		
		void WorktimerTick(object sender, EventArgs e)
		{
			if(nowtask==0)
			{
				taskbut1.ForeColor=Color.Yellow;
				taskbut2.ForeColor=Color.Aqua;
				taskbut3.ForeColor=Color.Aqua;
			}
			if(nowtask==1)
			{
				taskbut1.ForeColor=Color.Aqua;
				taskbut2.ForeColor=Color.Yellow;
				taskbut3.ForeColor=Color.Aqua;
			}
			if(nowtask==2)
			{
				taskbut1.ForeColor=Color.Aqua;
				taskbut2.ForeColor=Color.Aqua;
				taskbut3.ForeColor=Color.Yellow;
			}
			
			///////////////////////////////////////////////////////////////////////////////////////////////
			// ui show
			if(tasklist[nowtask].procchoint==1)
			{
				procchoosed.Text=tasklist[nowtask].name.ProcessName.ToString();
			}
			else{
				procchoosed.Text="Unchoosed";
			}
			
			
			
			if(tasklist[nowtask].working==1)
			{
				startbut.Text="StopTask";
			}else{
				startbut.Text="StartTask";
			}
			
			
			
			
			if(tasklist[nowtask].working==1)
			{
				proclist.Visible=true;
				
				
			}
			else
			{
				proclist.Visible=false;
				proclist.Items.Clear();
			}
			
			if(tasklist[nowtask].dllname!=String.Empty)
			{
				dllpath.Text=tasklist[nowtask].dllname;
			}
			else
			{
				dllpath.Text="dll path Unchoosed";
			}
			
			searchshow.Text=tasklist[nowtask].searchname;
			
			
			
			
			
			
			if(searchstate==0)
			{
				searchshow.Visible=true;
				searchproc.Visible=false;
				searchbut.Text="Search";
			}
			if(searchstate==1)
			{
				searchshow.Visible=false;
				searchproc.Visible=true;
				searchbut.Text="Start Search";
			}
			if(searchstate==2)
			{
				searchshow.Visible=true;
				searchproc.Visible=false;
				searchbut.Text="New Search";
			}
			
			
		/*	
			if(tasklist[nowtask].working==1)
			{
				if(tasklist[nowtask].pname!=null)
				{
					foreach(Process showname in tasklist[nowtask].pname)
						{
						if(proclist.SelectedItem!=null)
						{
							if(showname.ProcessName==proclist.SelectedItem.ToString())
							{
								tasklist[nowtask].name=showname;
							}
						}
					}
				}
			}
		*/	
			
		}
		void ProclistSelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		void ProclistMouseEnter(object sender, EventArgs e)
		{
	//		lock(this)
			{
				chooseing=1;
			}
			
		}
		void ProclistMouseLeave(object sender, EventArgs e)
		{
	//		lock(this)
			{
				chooseing=0;
			}
			
		}
		void ProclistDoubleClick(object sender, EventArgs e)
		{
			string a=proclist.SelectedItem.ToString();
		//	MessageBox.Show(a);
			foreach(Process showname in tasklist[nowtask].pname)
			{
				if(proclist.SelectedItem!=null)
				{
					if(showname.ProcessName==a)
					{
						tasklist[nowtask].procchoint=1;
						tasklist[nowtask].name=showname;
					}
				}
			}
		}
		
		
		
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
		
		
		
		void Panel2DragDrop(object sender, DragEventArgs e)
		{
			int tipstate=0;
			string[] filePath = (string[])e.Data.GetData(DataFormats.FileDrop);
			tasklist[nowtask].dllname=String .Empty;
			foreach(string feach in filePath)
			{
				if(feach.EndsWith(".dll"))
				{
				   	tipstate++;
				tasklist[nowtask].dllname+=feach+"#";
				}
				
			}
			Constlab2.Text="Dll File  x"+tipstate.ToString();
		//	MessageBox.Show(tasklist[nowtask].dllname);
		}
		void SetdllDragDrop(object sender, DragEventArgs e)
		{
			int tipstate=0;
			string[] filePath = (string[])e.Data.GetData(DataFormats.FileDrop);
			tasklist[nowtask].dllname=String .Empty;
			foreach(string feach in filePath)
			{
				if(feach.EndsWith(".dll"))
				{
				   	tipstate++;
				tasklist[nowtask].dllname+=feach+"#";
				}
				
			}
			Constlab2.Text="Dll File  x"+tipstate.ToString();
		//	MessageBox.Show(tasklist[nowtask].dllname);
		}
		void Constlab2DragDrop(object sender, DragEventArgs e)
		{
			int tipstate=0;
			string[] filePath = (string[])e.Data.GetData(DataFormats.FileDrop);
			tasklist[nowtask].dllname=String .Empty;
			foreach(string feach in filePath)
			{
				if(feach.EndsWith(".dll"))
				{
				   	tipstate++;
				tasklist[nowtask].dllname+=feach+"#";
				}
				
			}
			Constlab2.Text="Dll File  x"+tipstate.ToString();
		//	MessageBox.Show(tasklist[nowtask].dllname);
		}
		void Label1DragDrop(object sender, DragEventArgs e)
		{
			int tipstate=0;
			string[] filePath = (string[])e.Data.GetData(DataFormats.FileDrop);
			tasklist[nowtask].dllname=String .Empty;
			foreach(string feach in filePath)
			{
				if(feach.EndsWith(".dll"))
				{
				   	tipstate++;
				tasklist[nowtask].dllname+=feach+"#";
				}
				
			}
			Constlab2.Text="Dll File  x"+tipstate.ToString();
		//	MessageBox.Show(tasklist[nowtask].dllname);
		}
		
		
		
		
		void Panel2DragEnter(object sender, DragEventArgs e)
		{
			 if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Link;
           	 else e.Effect = DragDropEffects.None;
		}
		void Constlab2DragEnter(object sender, DragEventArgs e)
		{
			 if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Link;
           	 else e.Effect = DragDropEffects.None;
		}
		void Label1DragEnter(object sender, DragEventArgs e)
		{
			 if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Link;
           	 else e.Effect = DragDropEffects.None;
		}
		void SetdllDragEnter(object sender, DragEventArgs e)
		{
			 if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Link;
           	 else e.Effect = DragDropEffects.None;
		}
		void DllpathClick(object sender, EventArgs e)
		{
			MessageBox.Show(tasklist[nowtask].dllname.Replace(@"#",Environment.NewLine),"将注入以下DLL");
		}
		void InjectbutClick(object sender, EventArgs e)
		{
			string[] dllnameinjlist;
			if(tasklist[nowtask].dllname!=String.Empty)
			{
				dllnameinjlist=tasklist[nowtask].dllname.Split('#');
				
			}else{
				MessageBox.Show("dllnotfound");
				return;
			}
			
			if(tasklist[nowtask].name!=null)
			{
		
			foreach(string dllnameinj in dllnameinjlist)
			{
		//		MessageBox.Show(dllnameinj.Replace(@"\",@"\\"));
				Thread injthr=new Thread(() => injectfun(tasklist[nowtask].name,dllnameinj.Replace(@"\",@"\\")));
				injthr.Start();
				
			}
			
				
			}else{
				MessageBox.Show("procnotfound");
				return;
			}
			
		}
		void SetdllClick(object sender, EventArgs e)
		{
			openFileDialog1.ShowDialog();
			
			int tipstate=0;
			string[] filePath =openFileDialog1.FileNames;
			tasklist[nowtask].dllname=String .Empty;
			foreach(string feach in filePath)
			{
				if(feach.EndsWith(".dll"))
				{
				   	tipstate++;
				tasklist[nowtask].dllname+=feach+"#";
				}
				
			}
			Constlab2.Text="Dll File  x"+tipstate.ToString();
		}
		void SearchbutClick(object sender, EventArgs e)
		{
			if(searchstate==0)
			{
				searchstate=1;
			}
			if(searchstate==1)
			{
				searchstate=2;
				return;
			}
			if(searchstate==2)
			{
				searchstate=1;
				return;
			}
			
		}
		void SearchprocLeave(object sender, EventArgs e)
		{
			searchshow.Visible=true;
			searchproc.Visible=false;
		}
		void SearchprocTextChanged(object sender, EventArgs e)
		{
			tasklist[nowtask].searchname=searchproc.Text;
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			ResourceManager a=new ResourceManager("Hookernel.Resource1",this.GetType().Assembly);
			Bitmap bsy=(Bitmap)a.GetObject("sy");
			Bitmap bbg=(Bitmap)this.BackgroundImage;
			Graphics g=Graphics.FromImage(bbg);
			g.DrawImage(bsy,0,0,700,390);
			g.DrawImage(bsy,1398,0,-700,390);
			this.BackgroundImage=(Image)bbg;
		}
		
		
		
		
		
		
		
		
		
	}
}
