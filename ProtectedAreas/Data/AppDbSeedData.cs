using System;
using ProtectedAreas.Models;

namespace ProtectedAreas.Data
{
    public static class AppDbSeedData
    {
        public static void LoadSeedData(AppDbContext dbContext)
        {
            LoadProtectedArea(dbContext);
            LoadObsoleteNames(dbContext);
            LoadInternationalStatuses(dbContext);
            LoadLiquidations(dbContext);

            dbContext.SaveChanges();
        }

        private static void LoadProtectedArea(AppDbContext dbContext)
        {
            dbContext.ProtectedAreas.Add(new ProtectedArea
            {
                CadastralFileNumber = "5646",
                Status = "Действующая",
                FullName = "Сочинский национальный парк",
                ShortName = "ООПТ Сочинский",
                Category = "Государственные природные заказники",
                Significance = "федеральное",
                Profile = "комплексный",
                CreationDate = new DateTime(1993, 12, 3),
                RestorationDate = new DateTime()
            });
        }

        private static void LoadObsoleteNames(AppDbContext dbContext)
        {
            dbContext.ObsoleteNames.Add(new ObsoleteName { Number = 1, Name = "Старое название", ProtectedAreaId = 1 });
            dbContext.ObsoleteNames.Add(new ObsoleteName { Number = 2, Name = "Другое старое название", ProtectedAreaId = 1 });
        }

        private static void LoadInternationalStatuses(AppDbContext dbContext)
        {
            dbContext.InternationalStatuses.Add(new InternationalStatus
            {
                Number = 1,
                Status = "Водно-болотное угодье международного значения",
                Name = "Водно-болотное угодье",
                Document = "Пример документа",
                ProtectedAreaId = 1
            });
        }

        private static void LoadLiquidations(AppDbContext dbContext)
        {
            dbContext.Liquidations.Add(new Liquidation
            {
                Number = 1, Date = new DateTime(1982, 1, 15), Type = "реорганизация", ProtectedAreaId = 1
            });
            dbContext.Liquidations.Add(new Liquidation
            {
                Number = 2, Date = new DateTime(2020, 1, 15), Type = "реорганизация", ProtectedAreaId = 1
            });
        }
    }
}