﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DanfeSharp.Test
{
    [TestClass]
    public class DanfeTest
    {
        [TestMethod]
        public void Retrato()
        {
            var model = FabricaFake.DanfeViewModel_1();
            model.Orientacao = Orientacao.Retrato;
            DanfeSharp.Danfe d = new DanfeSharp.Danfe(model);       
            d.Gerar();
            d.SalvarTestPdf();
        }

        [TestMethod]
        public void Paisagem()
        {
            var model = FabricaFake.DanfeViewModel_1();
            model.Orientacao = Orientacao.Paisagem;
            DanfeSharp.Danfe d = new DanfeSharp.Danfe(model);
            d.Gerar();
            d.SalvarTestPdf();
        }

    }
}