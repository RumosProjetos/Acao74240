﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapataria.LogicaNegocio
{
    public static class LogHelper
    {
        private const string path = @"c:\temp\log.txt";
        public static void GravarInformacaoEmArquivo(string mensagem)
        {
            File.AppendAllText(path, "\n" + mensagem);
        }

        public static void GravarInformacaoEmArquivo(string mensagem, Exception exception)
        {
            File.AppendAllText(path, "\n" + mensagem + "\t" + exception.Message);
        }

        public static void GravarInformacaoEmArquivo(Exception exception)
        {
            File.AppendAllText(path, "\n" + exception.Message);
        }

    }
}
