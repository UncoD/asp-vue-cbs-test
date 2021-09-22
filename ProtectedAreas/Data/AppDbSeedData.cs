using System;
using System.Collections.Generic;
using ProtectedAreas.Models;

namespace ProtectedAreas.Data
{
    public class AppDbSeedData
    {
        public ProtectedArea LoadProtectedArea()
        {
            return new ProtectedArea
            {
                Id = 1,
                CadastralFileNumber = "5646",
                Status = "Действующая",
                FullName = "Сочинский национальный парк",
                ShortName = "ООПТ Сочинский",
                ObsoleteNames = LoadAObsoleteNames(),
                Category = "Государственные природные заказники",
                Significance = "федеральное",
                Profile = "комплексный",
                CreationDate = new DateTime(1993, 12, 3),
                RestorationDate = new DateTime(),
                InternationalStatuses = LoadInternationalStatuses(),
                Liquidations = LoadLiquidations()
            };
        }

        public List<ObsoleteName> LoadAObsoleteNames()
        {
            return new List<ObsoleteName>()
            {
                new() { Id = 1, Number = 1, Name = "Старое название" },
                new() { Id = 1, Number = 2, Name = "Другое старое название" }
            };
        }

        public List<InternationalStatus> LoadInternationalStatuses()
        {
            return new List<InternationalStatus>()
            {
                new() { Id = 1, Number = 1, Status = "Водно-болотное угодье международного значения", Name = "Водно-болотное угодье", Document = "Пример документа"}
            };
        }

        public List<Liquidation> LoadLiquidations()
        {
            return new List<Liquidation>()
            {
                new() { Id = 1, Number = 1, Date = new DateTime(1982, 1, 15), Type = "реорганизация"},
                new() { Id = 1, Number = 2, Date = new DateTime(2020, 1, 15), Type = "реорганизация"}
            };
        }
    }
}