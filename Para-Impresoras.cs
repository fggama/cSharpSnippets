public static void DeterminaTipoImpresora()
{
	EsImpresoraTermica = false;
	using (PrintDocument PrintDoc = new PrintDocument())
	{
		PrintDoc.PrinterSettings.PrinterName = Impresora;
		PaperSize TamanioPapel;
		for (int j = 0; j < PrintDoc.PrinterSettings.PaperSizes.Count; j++)
		{
			TamanioPapel = PrintDoc.PrinterSettings.PaperSizes[j];
			if (TamanioPapel.PaperName.Contains("Roll"))
			{
				EsImpresoraTermica = true;
				break;
			}
		}
	}
}

public static bool EstablecerImpresoraPorDefecto(string sNombreImpresora)
{
	bool Result = false;
	try
	{
		Result = NativeMethods.SetDefaultPrinter(sNombreImpresora);
		Impresora = sNombreImpresora;
		DeterminaTipoImpresora();
	}
	catch (Exception ex)
	{
		MessageBox.Show(ex.Message, "clParametros.establecerImpresoraPorDefecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
	}
	return Result;
}
