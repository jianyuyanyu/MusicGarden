using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicGarden
{
    public class TxtClass
    {
		public void TxtWrite(string filepath, string str)
		{
			try
			{
				if (File.Exists(filepath) || MessageBox.Show("您所指定地址的txt文件不存在,是否创建该文件并写入内容?", "提示消息", MessageBoxButtons.OKCancel) != DialogResult.Cancel)
				{
					FileStream fileStream = new FileStream(filepath, FileMode.Append, FileAccess.Write);
					StreamWriter streamWriter = new StreamWriter(fileStream);
					streamWriter.WriteLine(str);
					streamWriter.Flush();
					streamWriter.Close();
					fileStream.Close();
				}
			}
			catch (Exception ex)
			{
				string text = ex.ToString();
				if (ex.InnerException != null)
				{
					text += ex.InnerException.ToString();
				}
				if (ex.StackTrace != null)
				{
					text += ex.StackTrace.ToString();
				}
				MessageBox.Show(text);
			}
		}

		public string TxtRead(string filepath)
		{
			string result = "";
			try
			{
				FileStream fileStream = new FileStream(filepath, FileMode.Open, FileAccess.Read);
				StreamReader streamReader = new StreamReader(fileStream);
				streamReader.BaseStream.Seek(0L, SeekOrigin.Begin);
				result = streamReader.ReadToEnd();
				streamReader.Close();
				fileStream.Close();
			}
			catch (Exception ex)
			{
				string text = ex.ToString();
				if (ex.InnerException != null)
				{
					text += ex.InnerException.ToString();
				}
				if (ex.StackTrace != null)
				{
					text += ex.StackTrace.ToString();
				}
				MessageBox.Show(text);
			}
			return result;
		}

		public string TxtRead(string filepath, int rowbh)
		{
			string result = "";
			try
			{
				FileStream fileStream = new FileStream(filepath, FileMode.Open, FileAccess.Read);
				StreamReader streamReader = new StreamReader(fileStream);
				streamReader.BaseStream.Seek(0L, SeekOrigin.Begin);
				int num = 0;
				for (string text = streamReader.ReadLine(); text != null; text = streamReader.ReadLine())
				{
					num++;
					if (num == rowbh)
					{
						result = text;
						break;
					}
				}
				streamReader.Close();
				fileStream.Close();
			}
			catch (Exception ex)
			{
				string text2 = ex.ToString();
				if (ex.InnerException != null)
				{
					text2 += ex.InnerException.ToString();
				}
				if (ex.StackTrace != null)
				{
					text2 += ex.StackTrace.ToString();
				}
				MessageBox.Show(text2);
			}
			return result;
		}

		public DataTable TxtRead(string filepath, char split)
		{
			DataTable dataTable = new DataTable();
			try
			{
				FileStream fileStream = new FileStream(filepath, FileMode.Open, FileAccess.Read);
				StreamReader streamReader = new StreamReader(fileStream);
				streamReader.BaseStream.Seek(0L, SeekOrigin.Begin);
				string text = streamReader.ReadLine();
				if (text == "" || text == null)
				{
					return dataTable;
				}
				string[] array = text.Split(split);
				int num = array.Length;
				for (int i = 0; i < num; i++)
				{
					string columnName = "c" + i;
					dataTable.Columns.Add(columnName, typeof(string));
				}
				while (text != null && text != "")
				{
					string[] array2 = text.Split(split);
					DataRow dataRow = dataTable.NewRow();
					for (int j = 0; j < num; j++)
					{
						string columnName = "c" + j;
						dataRow[columnName] = array2[j];
					}
					dataTable.Rows.Add(dataRow);
					dataTable.AcceptChanges();
					text = streamReader.ReadLine();
				}
				streamReader.Close();
				fileStream.Close();
			}
			catch (Exception ex)
			{
				string text2 = ex.ToString();
				if (ex.InnerException != null)
				{
					text2 += ex.InnerException.ToString();
				}
				if (ex.StackTrace != null)
				{
					text2 += ex.StackTrace.ToString();
				}
				MessageBox.Show(text2);
			}
			return dataTable;
		}

		public DataTable TxtRead(string filepath, char split, string condition)
		{
			DataTable dataTable = new DataTable();
			try
			{
				FileStream fileStream = new FileStream(filepath, FileMode.Open, FileAccess.Read);
				StreamReader streamReader = new StreamReader(fileStream);
				streamReader.BaseStream.Seek(0L, SeekOrigin.Begin);
				string text = streamReader.ReadLine();
				if (text == "" || text == null)
				{
					return dataTable;
				}
				string[] array = text.Split(split);
				int num = array.Length;
				DataTable dataTable2 = new DataTable();
				for (int i = 0; i < num; i++)
				{
					string columnName = "c" + i;
					dataTable2.Columns.Add(columnName, typeof(string));
				}
				while (text != null && text != "")
				{
					string[] array2 = text.Split(split);
					DataRow dataRow = dataTable2.NewRow();
					for (int j = 0; j < num; j++)
					{
						string columnName = "c" + j;
						dataRow[columnName] = array2[j];
					}
					dataTable2.Rows.Add(dataRow);
					dataTable2.AcceptChanges();
					text = streamReader.ReadLine();
				}
				streamReader.Close();
				fileStream.Close();
				DataRow[] array3 = dataTable2.Select(condition);
				dataTable = dataTable2.Clone();
				if (array3.Length > 0)
				{
					for (int i = 0; i < array3.Length; i++)
					{
						dataTable.Rows.Add(array3[i].ItemArray);
					}
					dataTable.AcceptChanges();
				}
			}
			catch (Exception ex)
			{
				string text2 = ex.ToString();
				if (ex.InnerException != null)
				{
					text2 += ex.InnerException.ToString();
				}
				if (ex.StackTrace != null)
				{
					text2 += ex.StackTrace.ToString();
				}
				MessageBox.Show(text2);
			}
			return dataTable;
		}

		public DataTable TxtRead(string filepath, char split, string condition, string ordercondition)
		{
			DataTable dataTable = new DataTable();
			try
			{
				FileStream fileStream = new FileStream(filepath, FileMode.Open, FileAccess.Read);
				StreamReader streamReader = new StreamReader(fileStream);
				streamReader.BaseStream.Seek(0L, SeekOrigin.Begin);
				string text = streamReader.ReadLine();
				if (text == "" || text == null)
				{
					return dataTable;
				}
				string[] array = text.Split(split);
				int num = array.Length;
				DataTable dataTable2 = new DataTable();
				for (int i = 0; i < num; i++)
				{
					string columnName = "c" + i;
					dataTable2.Columns.Add(columnName, typeof(string));
				}
				while (text != null && text != "")
				{
					string[] array2 = text.Split(split);
					DataRow dataRow = dataTable2.NewRow();
					for (int j = 0; j < num; j++)
					{
						string columnName = "c" + j;
						dataRow[columnName] = array2[j];
					}
					dataTable2.Rows.Add(dataRow);
					dataTable2.AcceptChanges();
					text = streamReader.ReadLine();
				}
				streamReader.Close();
				fileStream.Close();
				DataRow[] array3 = dataTable2.Select(condition, ordercondition);
				dataTable = dataTable2.Clone();
				if (array3.Length > 0)
				{
					for (int i = 0; i < array3.Length; i++)
					{
						dataTable.Rows.Add(array3[i].ItemArray);
					}
					dataTable.AcceptChanges();
				}
			}
			catch (Exception ex)
			{
				string text2 = ex.ToString();
				if (ex.InnerException != null)
				{
					text2 += ex.InnerException.ToString();
				}
				if (ex.StackTrace != null)
				{
					text2 += ex.StackTrace.ToString();
				}
				MessageBox.Show(text2);
			}
			return dataTable;
		}

		public void TxtDelete(string filepath, char split, string condition)
		{
			DataTable dataTable = new DataTable();
			try
			{
				FileStream fileStream = new FileStream(filepath, FileMode.Open, FileAccess.Read);
				StreamReader streamReader = new StreamReader(fileStream);
				streamReader.BaseStream.Seek(0L, SeekOrigin.Begin);
				string text = streamReader.ReadLine();
				if (text == "" || text == null)
				{
					return;
				}
				string[] array = text.Split(split);
				int num = array.Length;
				for (int i = 0; i < num; i++)
				{
					string columnName = "c" + i;
					dataTable.Columns.Add(columnName, typeof(string));
				}
				while (text != null && text != "")
				{
					string[] array2 = text.Split(split);
					DataRow dataRow = dataTable.NewRow();
					for (int j = 0; j < num; j++)
					{
						string columnName = "c" + j;
						dataRow[columnName] = array2[j];
					}
					dataTable.Rows.Add(dataRow);
					dataTable.AcceptChanges();
					text = streamReader.ReadLine();
				}
				streamReader.Close();
				fileStream.Close();
				DataRow[] array3 = dataTable.Select(condition);
				if (array3.Length > 0)
				{
					for (int i = 0; i < array3.Length; i++)
					{
						dataTable.Rows.Remove(array3[i]);
					}
					dataTable.AcceptChanges();
				}
				File.Delete(filepath);
				FileStream fileStream2 = File.Create(filepath);
				fileStream2.Close();
				for (int i = 0; i < dataTable.Rows.Count; i++)
				{
					string text2 = dataTable.Rows[i]["c0"].ToString();
					for (int j = 1; j < num; j++)
					{
						string columnName = "c" + j;
						string text3 = dataTable.Rows[i][columnName].ToString();
						text2 = text2 + split + text3;
					}
					TxtWrite(filepath, text2);
				}
			}
			catch (Exception ex)
			{
				string text4 = ex.ToString();
				if (ex.InnerException != null)
				{
					text4 += ex.InnerException.ToString();
				}
				if (ex.StackTrace != null)
				{
					text4 += ex.StackTrace.ToString();
				}
				MessageBox.Show(text4);
			}
		}

		public DataTable DataTable_Select(DataTable dt, string condition, string ordercondition)
		{
			DataTable dataTable = new DataTable();
			try
			{
				DataRow[] array = dt.Select(condition, ordercondition);
				dataTable = dt.Clone();
				if (array.Length > 0)
				{
					for (int i = 0; i < array.Length; i++)
					{
						dataTable.Rows.Add(array[i].ItemArray);
					}
					dataTable.AcceptChanges();
				}
			}
			catch (Exception ex)
			{
				string text = ex.ToString();
				if (ex.InnerException != null)
				{
					text += ex.InnerException.ToString();
				}
				if (ex.StackTrace != null)
				{
					text += ex.StackTrace.ToString();
				}
				MessageBox.Show(text);
			}
			return dataTable;
		}

		public DataTable DataTable_Select(DataTable dt, string condition)
		{
			DataTable dataTable = new DataTable();
			try
			{
				DataRow[] array = dt.Select(condition);
				DataRow[] array2 = array;
				dataTable = dt.Clone();
				if (array.Length > 0)
				{
					for (int i = 0; i < array.Length; i++)
					{
						dataTable.Rows.Add(array2[i].ItemArray);
					}
					dataTable.AcceptChanges();
				}
			}
			catch (Exception ex)
			{
				string text = ex.ToString();
				if (ex.InnerException != null)
				{
					text += ex.InnerException.ToString();
				}
				if (ex.StackTrace != null)
				{
					text += ex.StackTrace.ToString();
				}
				MessageBox.Show(text);
			}
			return dataTable;
		}

		public DataTable TxtRead(string filepath, char[] split)
		{
			DataTable dataTable = new DataTable();
			try
			{
				FileStream fileStream = new FileStream(filepath, FileMode.Open, FileAccess.Read);
				StreamReader streamReader = new StreamReader(fileStream);
				streamReader.BaseStream.Seek(0L, SeekOrigin.Begin);
				string text = streamReader.ReadLine();
				if (text == "" || text == null)
				{
					return dataTable;
				}
				string[] array = text.Split(split);
				int num = array.Length;
				for (int i = 0; i < num; i++)
				{
					string columnName = "c" + i;
					dataTable.Columns.Add(columnName, typeof(string));
				}
				while (text != null && text != "")
				{
					string[] array2 = text.Split(split);
					DataRow dataRow = dataTable.NewRow();
					for (int j = 0; j < num; j++)
					{
						string columnName = "c" + j;
						dataRow[columnName] = array2[j];
					}
					dataTable.Rows.Add(dataRow);
					dataTable.AcceptChanges();
					text = streamReader.ReadLine();
				}
				streamReader.Close();
				fileStream.Close();
			}
			catch (Exception ex)
			{
				string text2 = ex.ToString();
				if (ex.InnerException != null)
				{
					text2 += ex.InnerException.ToString();
				}
				if (ex.StackTrace != null)
				{
					text2 += ex.StackTrace.ToString();
				}
				MessageBox.Show(text2);
			}
			return dataTable;
		}

		public DataTable TxtRead(string filepath, char[] split, string condition)
		{
			DataTable dataTable = new DataTable();
			try
			{
				FileStream fileStream = new FileStream(filepath, FileMode.Open, FileAccess.Read);
				StreamReader streamReader = new StreamReader(fileStream);
				streamReader.BaseStream.Seek(0L, SeekOrigin.Begin);
				string text = streamReader.ReadLine();
				if (text == "" || text == null)
				{
					return dataTable;
				}
				string[] array = text.Split(split);
				int num = array.Length;
				DataTable dataTable2 = new DataTable();
				for (int i = 0; i < num; i++)
				{
					string columnName = "c" + i;
					dataTable2.Columns.Add(columnName, typeof(string));
				}
				while (text != null && text != "")
				{
					string[] array2 = text.Split(split);
					DataRow dataRow = dataTable2.NewRow();
					for (int j = 0; j < num; j++)
					{
						string columnName = "c" + j;
						dataRow[columnName] = array2[j];
					}
					dataTable2.Rows.Add(dataRow);
					dataTable2.AcceptChanges();
					text = streamReader.ReadLine();
				}
				streamReader.Close();
				fileStream.Close();
				DataRow[] array3 = dataTable2.Select(condition);
				dataTable = dataTable2.Clone();
				if (array3.Length > 0)
				{
					for (int i = 0; i < array3.Length; i++)
					{
						dataTable.Rows.Add(array3[i].ItemArray);
					}
					dataTable.AcceptChanges();
				}
			}
			catch (Exception ex)
			{
				string text2 = ex.ToString();
				if (ex.InnerException != null)
				{
					text2 += ex.InnerException.ToString();
				}
				if (ex.StackTrace != null)
				{
					text2 += ex.StackTrace.ToString();
				}
				MessageBox.Show(text2);
			}
			return dataTable;
		}

		public DataTable TxtRead(string filepath, char[] split, string condition, string ordercondition)
		{
			DataTable dataTable = new DataTable();
			try
			{
				FileStream fileStream = new FileStream(filepath, FileMode.Open, FileAccess.Read);
				StreamReader streamReader = new StreamReader(fileStream);
				streamReader.BaseStream.Seek(0L, SeekOrigin.Begin);
				string text = streamReader.ReadLine();
				if (text == "" || text == null)
				{
					return dataTable;
				}
				string[] array = text.Split(split);
				int num = array.Length;
				DataTable dataTable2 = new DataTable();
				for (int i = 0; i < num; i++)
				{
					string columnName = "c" + i;
					dataTable2.Columns.Add(columnName, typeof(string));
				}
				while (text != null && text != "")
				{
					string[] array2 = text.Split(split);
					DataRow dataRow = dataTable2.NewRow();
					for (int j = 0; j < num; j++)
					{
						string columnName = "c" + j;
						dataRow[columnName] = array2[j];
					}
					dataTable2.Rows.Add(dataRow);
					dataTable2.AcceptChanges();
					text = streamReader.ReadLine();
				}
				streamReader.Close();
				fileStream.Close();
				DataRow[] array3 = dataTable2.Select(condition, ordercondition);
				dataTable = dataTable2.Clone();
				if (array3.Length > 0)
				{
					for (int i = 0; i < array3.Length; i++)
					{
						dataTable.Rows.Add(array3[i].ItemArray);
					}
					dataTable.AcceptChanges();
				}
			}
			catch (Exception ex)
			{
				string text2 = ex.ToString();
				if (ex.InnerException != null)
				{
					text2 += ex.InnerException.ToString();
				}
				if (ex.StackTrace != null)
				{
					text2 += ex.StackTrace.ToString();
				}
				MessageBox.Show(text2);
			}
			return dataTable;
		}
	}
}
