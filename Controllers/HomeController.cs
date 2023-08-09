using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SistemaConsultaTI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace SistemaConsultaTI.Controllers
{
	public class HomeController : Controller
	{

		private readonly IWebHostEnvironment _hostingEnvironment;

		public HomeController(IWebHostEnvironment hostingEnvironment)
		{
			_hostingEnvironment = hostingEnvironment;
		}

		public IActionResult Index()
		{
			return View();
		}

		

		//Metodo Leitura txt (Usa a biblioteca iTextSharp Adicionada pelo Nuget)

		public IActionResult LeituraGeral(String NomeArquivo)
		{
			string Caminho = Path.Combine ("C:/Estudos Programação/SistemaConsulta/SistemaConsultaTI/ConteudosTXT/" + NomeArquivo + ".txt");
			String[] Conteudo = System.IO.File.ReadAllLines(Caminho);

			ViewData["NomeArquivo"] = NomeArquivo;

			return View((object)Conteudo);

		}


		//Método Leitura PDF

		public IActionResult LeituraPDF(String NomePDF)
		{

			// Caminho do arquivo PDF
			string caminhoPDF = Path.Combine(_hostingEnvironment.ContentRootPath, "C:/Estudos Programação/SistemaConsulta/SistemaConsultaTI/ConteudoPDF/" + NomePDF + ".pdf");

			// Criação do objeto MemoryStream
			MemoryStream ms = new MemoryStream();

			// Leitura do arquivo PDF
			using (FileStream arquivo = new FileStream(caminhoPDF, FileMode.Open, FileAccess.Read))
			{
				// Criação do objeto PdfReader
				PdfReader reader = new PdfReader(arquivo);

				// Criação do objeto Document
				Document document = new Document(reader.GetPageSizeWithRotation(1));

				// Criação do objeto PdfCopy
				PdfCopy copy = new PdfCopy(document, ms);

				// Abertura do documento
				document.Open();

				// Adiciona cada página do PDF ao documento
				for (int i = 1; i <= reader.NumberOfPages; i++)
				{
					PdfImportedPage importedPage = copy.GetImportedPage(reader, i);
					copy.AddPage(importedPage);
				}

				// Fechamento dos objetos
				copy.Close();
				document.Close();
				reader.Close();
			}

			ViewData["NomeArquivo"] = NomePDF;

			// Retorna o conteúdo do PDF
			return File(ms.ToArray(), "application/pdf");

		}

			




		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
