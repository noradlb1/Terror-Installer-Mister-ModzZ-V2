using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

// Token: 0x0200000C RID: 12
public static class Encrypt
{
	// Token: 0x06000037 RID: 55 RVA: 0x00004458 File Offset: 0x00002658
	public static string EncryptString(string plainText, string passPhrase)
	{
		byte[] bytes = Encoding.ASCII.GetBytes("pemgail9uzpgzl88");
		byte[] bytes2 = Encoding.UTF8.GetBytes(plainText);
		byte[] bytes3 = new PasswordDeriveBytes(passPhrase, null).GetBytes(8);
		ICryptoTransform transform = new RijndaelManaged
		{
			Mode = CipherMode.CBC
		}.CreateEncryptor(bytes3, bytes);
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
		cryptoStream.Write(bytes2, 0, bytes2.Length);
		cryptoStream.FlushFinalBlock();
		byte[] inArray = memoryStream.ToArray();
		memoryStream.Close();
		cryptoStream.Close();
		return Convert.ToBase64String(inArray);
	}

	// Token: 0x06000038 RID: 56 RVA: 0x000044E0 File Offset: 0x000026E0
	public static string DecryptString(string cipherText, string passPhrase)
	{
		byte[] bytes = Encoding.UTF8.GetBytes("pemgail9uzpgzl88");
		byte[] array = Convert.FromBase64String(cipherText);
		byte[] bytes2 = new PasswordDeriveBytes(passPhrase, null).GetBytes(8);
		ICryptoTransform transform = new RijndaelManaged
		{
			Mode = CipherMode.CBC
		}.CreateDecryptor(bytes2, bytes);
		MemoryStream memoryStream = new MemoryStream(array);
		CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read);
		byte[] array2 = new byte[array.Length];
		int count = cryptoStream.Read(array2, 0, array2.Length);
		memoryStream.Close();
		cryptoStream.Close();
		return Encoding.UTF8.GetString(array2, 0, count);
	}

	// Token: 0x0400002C RID: 44
	private const string initVector = "pemgail9uzpgzl88";

	// Token: 0x0400002D RID: 45
	private const int keysize = 64;
}
