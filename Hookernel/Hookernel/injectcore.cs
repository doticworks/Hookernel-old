/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2020/3/7
 * 时间: 10:20
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
	/// Description of injectcore.
	/// </summary>
	public class injectcore
	{
		  [DllImport("kernel32.dll")] //声明API函数
			public static extern int VirtualAllocEx(IntPtr hwnd, int lpaddress, int size, int type, int tect);
		 [DllImport("kernel32.dll")]
			public static extern int WriteProcessMemory(IntPtr hwnd, int baseaddress, string buffer, int nsize, int filewriten );
		 [DllImport("kernel32.dll")]
			public static extern int GetProcAddress(int hwnd, string lpname);
		 [DllImport("kernel32.dll")]
			public static extern int GetModuleHandleA(string name);
		 [DllImport("kernel32.dll")]
			public static extern int CreateRemoteThread(IntPtr hwnd, int attrib, int size, int address, int par, int flags, int threadid);
		
		public void injectfun(Process proc,string dll)
		{
			
				int dlllength=dll.Length+1;
				int baseaddress;
				int ok1;
				int temp=0;
				int hack;
				int yan;
				baseaddress = VirtualAllocEx(proc.Handle, 0, dlllength , 4096, 4); //申请内存空间
				if (baseaddress == 0) //返回0则操作失败，下面都是
				{
					MessageBox.Show("申请内存空间失败");
 				}
 				ok1 = WriteProcessMemory(proc.Handle, baseaddress, dll, dlllength, temp); //写内存
				if (ok1 == 0)
				{
					MessageBox.Show("写内存失败");
		
				}
				hack = GetProcAddress(GetModuleHandleA("Kernel32"), "LoadLibraryA"); //取得loadlibarary在kernek32.dll地址
				if (hack == 0)
				{
					MessageBox.Show("无法取得函数的入口点");			
		
 				}
 				yan = CreateRemoteThread(proc.Handle, 0, 0, hack, baseaddress, 0, temp); //创建远程线程。
				if (yan == 0)
				{
					MessageBox.Show("创建远程线程失败");
		
 				}
				else
				{
					MessageBox.Show("已成功注入dll");
				}
			
			
		}
	}
}
