using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSystemsProject.Utility
{
	public abstract class PasswordEncryption
	{
		public static byte[] GenerateSalt(int size = 16)
		{
			using (var rng = new System.Security.Cryptography.RNGCryptoServiceProvider())
			{
				byte[] salt = new byte[size];
				rng.GetBytes(salt);
				return salt;
			}
		}


		public static byte[] HashPassword(string password, byte[] salt)
		{
			using (var sha256 = System.Security.Cryptography.SHA256.Create())
			{
				byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);
				byte[] saltedPassword = new byte[salt.Length + passwordBytes.Length];

				Buffer.BlockCopy(salt, 0, saltedPassword, 0, salt.Length);
				Buffer.BlockCopy(passwordBytes, 0, saltedPassword, salt.Length, passwordBytes.Length);

				return sha256.ComputeHash(saltedPassword);
			}
		}


		public static string ByteArrayToHexString(byte[] byteArray)
		{
			return BitConverter.ToString(byteArray).Replace("-", "").ToLower();
		}


		public static byte[] HexStringToByteArray(string hexString)
		{
			int length = hexString.Length;
			byte[] byteArray = new byte[length / 2];
			for (int i = 0; i < length; i += 2)
			{
				byteArray[i / 2] = Convert.ToByte(hexString.Substring(i, 2), 16);
			}
			return byteArray;
		}


		public static bool CompareByteArrays(byte[] array1, byte[] array2)
		{
			if (array1.Length != array2.Length)
				return false;

			for (int i = 0; i < array1.Length; i++)
			{
				if (array1[i] != array2[i])
					return false;
			}
			return true;
		}


	}
}
