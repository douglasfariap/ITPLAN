using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CataProcesso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a Matricula do Funcionário: ");
            int mat = int.Parse(Console.ReadLine());
            Funcionarios fun = new Funcionarios(mat);
            fun.matricula = mat;

            //____________Criar Diretorio na area de trabalho_________________________
            String targetPath = Directory.GetCurrentDirectory() + @"\" + fun.BuscaNomeFunc(fun.matricula);
            Console.WriteLine(targetPath);
            System.IO.Directory.CreateDirectory(targetPath);

            //************************************COPIAR FR************************************************
            String sourcePatch = @"\\ad\Documentos Funcionarios\Ficha_registro\1-fichas por matricula";
            String fileName = fun.BuscaFR(fun.matricula);
            String sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            String destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            //************************************COPIAR TR************************************************
            sourcePatch = @"\\AD\Documentos Funcionarios\Rescisao\TRCT";
            fileName = fun.BuscaTRCT(fun.matricula);
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            //************************************COPIAR FGTS ITPLAN************************************************
            sourcePatch = @"\\ad\Documentos Funcionarios\Extratos_FGTS\itplan";
            fileName = fun.BuscaFGTSItplan(fun.matricula);
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            //************************************COPIAR FGTS Probid************************************************
            sourcePatch = @"\\ad\Documentos Funcionarios\Extratos_FGTS\probid";
            fileName = fun.BuscaFGTSProbid(fun.matricula);
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            //************************************COPIAR CT************************************************
            sourcePatch = @"\\ad\Documentos Funcionarios\Contratos_de_Trabalho";
            fileName = fun.BuscaCT(fun.matricula);
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            //************************************COPIAR AA************************************************
            sourcePatch = @"\\ad\Documentos Funcionarios\ASO\ADMISSIONAL";
            fileName = fun.BuscaAA(fun.matricula);
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }

            //************************************COPIAR AD************************************************
            sourcePatch = @"\\ad\Documentos Funcionarios\ASO\DEMISSIONAL";
            fileName = fun.BuscaAD(fun.matricula);
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            //Console.WriteLine(fun.nomehl[0]);
            //************************************COPIAR HLs************************************************
            sourcePatch = @"\\AD\Documentos Funcionarios\Contra_Cheques\2017\11 - Novembro";
            fileName = fun.nomehl[0];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"\\AD\Documentos Funcionarios\Contra_Cheques\2017\12 - Dezembro";
            fileName = fun.nomehl[1];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"\\AD\Documentos Funcionarios\Contra_Cheques\2017\13 - Dezembro";
            fileName = fun.nomehl[2];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"\\AD\Documentos Funcionarios\Contra_Cheques\2018\01 - JANEIRO";
            fileName = fun.nomehl[3];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"\\AD\Documentos Funcionarios\Contra_Cheques\2018\02 - FEVEREIRO";
            fileName = fun.nomehl[4];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"\\AD\Documentos Funcionarios\Contra_Cheques\2018\03 - MARÇO";
            fileName = fun.nomehl[5];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"\\AD\Documentos Funcionarios\Contra_Cheques\2018\04 - ABRIL";
            fileName = fun.nomehl[6];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"\\AD\Documentos Funcionarios\Contra_Cheques\2018\05 - MAIO";
            fileName = fun.nomehl[7];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"\\AD\Documentos Funcionarios\Contra_Cheques\2018\06 - JUNHO";
            fileName = fun.nomehl[8];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"\\AD\Documentos Funcionarios\Contra_Cheques\2018\07 - JULHO";
            fileName = fun.nomehl[9];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"\\AD\Documentos Funcionarios\Contra_Cheques\2018\08 - AGOSTO";
            fileName = fun.nomehl[10];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"\\AD\Documentos Funcionarios\Contra_Cheques\2018\09 - SETEMBRO";
            fileName = fun.nomehl[11];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"\\AD\Documentos Funcionarios\Contra_Cheques\2018\10 - OUTUBRO";
            fileName = fun.nomehl[12];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"\\AD\Documentos Funcionarios\Contra_Cheques\2018\11 - NOVEMBRO";
            fileName = fun.nomehl[13];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"\\AD\Documentos Funcionarios\Contra_Cheques\2018\12 - DEZEMBRO";
            fileName = fun.nomehl[14];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"\\AD\Documentos Funcionarios\Contra_Cheques\2018\13 - DEZEMBRO";
            fileName = fun.nomehl[15];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"\\AD\Documentos Funcionarios\Contra_Cheques\2019\01- JANEIRO";
            fileName = fun.nomehl[16];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"\\AD\Documentos Funcionarios\Contra_Cheques\2019\02 - FEVEREIRO";
            fileName = fun.nomehl[17];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"\\AD\Documentos Funcionarios\Contra_Cheques\2019\03 - MARÇO";
            fileName = fun.nomehl[18];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"\\AD\Documentos Funcionarios\Contra_Cheques\2019\04 - ABRIL";
            fileName = fun.nomehl[19];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }

            //************************************COPIAR CPs************************************************
            sourcePatch = @"\\AD\Documentos Funcionarios\Comprovantes_de_pagamentos\2017\2017-11";
            fileName = fun.nomecp[0];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"\\AD\Documentos Funcionarios\Comprovantes_de_pagamentos\2017\2017-12";
            fileName = fun.nomecp[1];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"\\AD\Documentos Funcionarios\Comprovantes_de_pagamentos\2017\2017-13";
            fileName = fun.nomecp[2];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"\\AD\Documentos Funcionarios\Comprovantes_de_pagamentos\2018\2018-01";
            fileName = fun.nomecp[3];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"\\AD\Documentos Funcionarios\Comprovantes_de_pagamentos\2018\2018-02";
            fileName = fun.nomecp[4];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"\\AD\Documentos Funcionarios\Comprovantes_de_pagamentos\2018\2018-03";
            fileName = fun.nomecp[5];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"\\AD\Documentos Funcionarios\Comprovantes_de_pagamentos\2018\2018-04";
            fileName = fun.nomecp[6];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"\\AD\Documentos Funcionarios\Comprovantes_de_pagamentos\2018\2018-05";
            fileName = fun.nomecp[7];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"\\AD\Documentos Funcionarios\Comprovantes_de_pagamentos\2018\2018-06";
            fileName = fun.nomecp[8];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"\\AD\Documentos Funcionarios\Comprovantes_de_pagamentos\2018\2018-07";
            fileName = fun.nomecp[9];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"\\AD\Documentos Funcionarios\Comprovantes_de_pagamentos\2018\2018-08";
            fileName = fun.nomecp[10];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"\\AD\Documentos Funcionarios\Comprovantes_de_pagamentos\2018\2018-09";
            fileName = fun.nomecp[11];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"\\AD\Documentos Funcionarios\Comprovantes_de_pagamentos\2018\2018-10";
            fileName = fun.nomecp[12];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"\\AD\Documentos Funcionarios\Comprovantes_de_pagamentos\2018\2018-11";
            fileName = fun.nomecp[13];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"\\AD\Documentos Funcionarios\Comprovantes_de_pagamentos\2018\2018-12";
            fileName = fun.nomecp[14];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"\\AD\Documentos Funcionarios\Comprovantes_de_pagamentos\2018\2018-13-1";
            fileName = fun.nomecp[15];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"\\AD\Documentos Funcionarios\Comprovantes_de_pagamentos\2018\2018-13-2";
            fileName = fun.nomecp[16];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"\\AD\Documentos Funcionarios\Comprovantes_de_pagamentos\2019\2019-01";
            fileName = fun.nomecp[17];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            
            //************************************COPIAR FPs************************************************
            sourcePatch = @"\\AD\Documentos Funcionarios\Folhas_de_ponto\2017\11";
            fileName = fun.nomefp[0];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"\\AD\Documentos Funcionarios\Folhas_de_ponto\2017\12";
            fileName = fun.nomefp[1];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"\\AD\Documentos Funcionarios\Folhas_de_ponto\2018\1";
            fileName = fun.nomefp[2];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"\\AD\Documentos Funcionarios\Folhas_de_ponto\2018\2";
            fileName = fun.nomefp[3];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"\\AD\Documentos Funcionarios\Folhas_de_ponto\2018\3";
            fileName = fun.nomefp[4];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"\\AD\Documentos Funcionarios\Folhas_de_ponto\2018\4";
            fileName = fun.nomefp[5];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"\\AD\Documentos Funcionarios\Folhas_de_ponto\2018\5";
            fileName = fun.nomefp[6];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"\\AD\Documentos Funcionarios\Folhas_de_ponto\2018\6";
            fileName = fun.nomefp[7];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"\\AD\Documentos Funcionarios\Folhas_de_ponto\2018\7";
            fileName = fun.nomefp[8];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"\\AD\Documentos Funcionarios\Folhas_de_ponto\2018\8";
            fileName = fun.nomefp[9];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"\\AD\Documentos Funcionarios\Folhas_de_ponto\2018\9";
            fileName = fun.nomefp[10];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"\\AD\Documentos Funcionarios\Folhas_de_ponto\2018\10";
            fileName = fun.nomefp[11];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"\\AD\Documentos Funcionarios\Folhas_de_ponto\2018\11";
            fileName = fun.nomefp[12];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"\\AD\Documentos Funcionarios\Folhas_de_ponto\2018\12";
            fileName = fun.nomefp[13];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"\\AD\Documentos Funcionarios\Folhas_de_ponto\2019\01";
            fileName = fun.nomefp[14];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"\\AD\Documentos Funcionarios\Folhas_de_ponto\2019\02";
            fileName = fun.nomefp[15];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }

            Console.WriteLine("Pressione qualquer tecla para finalizar...");
            Console.ReadKey();
            
        }
    }
}
