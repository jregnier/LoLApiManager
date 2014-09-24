
namespace Team7.LoLApiManager.Test
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Team7.LoLAPIManager;
    using Team7.LoLAPIManager.Core;
    using Team7.LoLAPIManager.Models;
    using System.Threading.Tasks;

    [TestClass]
    public class LoLManagerTest
    {
        [TestMethod]
        public async Task ConstructorTest()
        {
            LoLManager.Instance.Initialize("a118bc3c-69d5-4be1-a99a-92a83a954689", ApiRegions.NA);
            ChampionList champs1 = await LoLManager.Instance.Champion.GetAsync();
            ChampionList champs2 = await LoLManager.Instance.Champion.GetAsync(true);
            ChampionList champs3 = await LoLManager.Instance.Champion.GetAsync(false);

            Champion champ1 = await LoLManager.Instance.Champion.GetAsync(1);

            for (int i = 0; i < 50; i++)
            {
                var cha = await LoLManager.Instance.Champion.GetAsync(i);
            }
        }
    }
}
