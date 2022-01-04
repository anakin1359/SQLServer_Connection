using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoimi
{
	internal static class Program
	{
		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.ThreadException += Application_ThreadException;

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new InsertCommandButton());
		}

		private static void Application_ThreadException(
			object sender, System.Threading.ThreadExceptionEventArgs e)
		{
			// 例外が発生した場合、例外の内容を受け取りメッセージ出力する処理を実装
			MessageBox.Show(e.Exception.Message);
		}
	}
}
