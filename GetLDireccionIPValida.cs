 private static string GetLDireccionIPValida()
{
	try
	{
		var host = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName());
		foreach (var ip in host.AddressList)
		{
			if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork && ip.ToString().IndexOf("213") >= 0)
			{
				return ip.ToString();
			}
		}

		throw new Exception("No se encuentra una direccion IP válida!");
	}
	catch (Exception ex)
	{
		MessageBox.Show(ex.Message, "Inicializar Parametros", MessageBoxButtons.OK, MessageBoxIcon.Stop);
	}
	return "";
}