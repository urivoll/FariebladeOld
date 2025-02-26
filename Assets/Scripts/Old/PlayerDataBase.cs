using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerDataBase : MonoBehaviour
{
    [SerializeField] private DateTimeServer timeServer;
    public IEnumerator GeneralSettings()
    {
        string json = "";
        Dictionary<string, string> form = new Dictionary<string, string> {{ "action", "start" }};
        var cor = Http.HttpQurey(answer => json = answer, "script1", form);
        yield return cor;

        StartDataResponse response = JsonUtility.FromJson<StartDataResponse>(json);
        Campany.campanyProgress = response.campany;
        PlayerData.troop[0] = response._1_1;
        PlayerData.troop[1] = response._2_1;
        PlayerData.troop[2] = response._1_2;
        PlayerData.troop[3] = response._2_2;
        PlayerData.troop[4] = response._1_3;
        PlayerData.troop[5] = response._2_3;
        PlayerData.nick = response.nickName;
        PlayerData.accountLevel = response.accountLevel;
        PlayerData.accountExp = response.accountExp;
        PlayerData.portrait = response.portrait;
        PlayerData.rank = response.ranking;
        DateTimeServer.dayInRow = response.dayInRow;
        DateTimeServer.lastEnter = response.lastEnter;
        PlayerData.freeDf = response.freeDf;

        ChestTake.slotTime[0] = response.slot0Time;
        ChestTake.slotTime[1] = response.slot1Time;
        ChestTake.slotTime[2] = response.slot2Time;
        ChestTake.slotTime[3] = response.slot3Time;
        ChestTake.slotTime[4] = response.slot4Time;
        ChestTake.slotRar[0] = response.slot0Rar;
        ChestTake.slotRar[1] = response.slot1Rar;
        ChestTake.slotRar[2] = response.slot2Rar;
        ChestTake.slotRar[3] = response.slot3Rar;
        ChestTake.slotRar[4] = response.slot4Rar;

        Inventory.InventoryPlayer[0] = response.id0;
        Inventory.InventoryPlayer[1] = response.id1;
        Inventory.InventoryPlayer[2] = response.id2;
        Inventory.InventoryPlayer[3] = response.id3;
        Inventory.InventoryPlayer[4] = response.id4;
        Inventory.InventoryPlayer[5] = response.id5;
        Inventory.InventoryPlayer[6] = response.id6;
        Inventory.InventoryPlayer[7] = response.id7;
        Inventory.InventoryPlayer[8] = response.id8;
        Inventory.InventoryPlayer[9] = response.id9;
        Inventory.InventoryPlayer[10] = response.id10;
        Inventory.InventoryPlayer[11] = response.id11;
        Inventory.InventoryPlayer[12] = response.id12;
        Inventory.InventoryPlayer[13] = response.id13;
        Inventory.InventoryPlayer[14] = response.id14;
        Inventory.InventoryPlayer[15] = response.id15;
        Inventory.InventoryPlayer[16] = response.id16;
        Inventory.InventoryPlayer[17] = response.id17;
        Inventory.InventoryPlayer[18] = response.id18;
        Inventory.InventoryPlayer[19] = response.id19;
        Inventory.InventoryPlayer[20] = response.id20;
        Inventory.InventoryPlayer[21] = response.id21;
        Inventory.InventoryPlayer[22] = response.id22;
        Inventory.InventoryPlayer[23] = response.id23;
        Inventory.InventoryPlayer[24] = response.id24;
        Inventory.InventoryPlayer[25] = response.id25;

        Campany.anIsTimeNeed[0] = response.anIs0TimeNeed;
        Campany.anIsTimeNeed[1] = response.anIs1TimeNeed;
        Campany.anIsTimeNeed[2] = response.anIs2TimeNeed;
        Campany.anIsProgress = response.anIsProgress;
        Campany.anIsLocation[0] = response.anIs0Location;
        Campany.anIsLocation[1] = response.anIs1Location;
        Campany.anIsLocation[2] = response.anIs2Location;
        Campany.anIsProsent[0] = response.anIs0Prosent;
        Campany.anIsProsent[1] = response.anIs1Prosent;
        Campany.anIsProsent[2] = response.anIs2Prosent;

        Dealer.Product[0] = response.product0;
        Dealer.Product[1] = response.product1;
        Dealer.Product[2] = response.product2;
        Dealer.Product[3] = response.product3;
        Dealer.Product[4] = response.product4;
        Dealer.Amount[0] = response.productAmount0;
        Dealer.Amount[1] = response.productAmount1;
        Dealer.Amount[2] = response.productAmount2;
        Dealer.Amount[3] = response.productAmount3;
        Dealer.Amount[4] = response.productAmount4;
        Dealer.Price[0] = response.productPrice0;
        Dealer.Price[1] = response.productPrice1;
        Dealer.Price[2] = response.productPrice2;
        Dealer.Price[3] = response.productPrice3;
        Dealer.Price[4] = response.productPrice4;
        Dealer.ProductSell[0] = response.productSell0;
        Dealer.ProductSell[1] = response.productSell1;
        Dealer.ProductSell[2] = response.productSell2;
        Dealer.ProductSell[3] = response.productSell3;
        Dealer.ProductSell[4] = response.productSell4;
        Dealer.ProductSellAmount[0] = response.productSellAmount0;
        Dealer.ProductSellAmount[1] = response.productSellAmount1;
        Dealer.ProductSellAmount[2] = response.productSellAmount2;
        Dealer.ProductSellAmount[3] = response.productSellAmount3;
        Dealer.ProductSellAmount[4] = response.productSellAmount4;
        Dealer.Time = response.time;
        json = "";
        form = new Dictionary<string, string> { { "action", "test" } };
        cor = Http.HttpQurey(answer => json = answer, "tasks", form);
        yield return cor;

        MyData obj = JsonConvert.DeserializeObject<MyData>(json);
        if (obj.day_change == 1) PlayerPrefs.SetInt("StickerId1", 1);
        if (obj.week_change == 1) PlayerPrefs.SetInt("StickerId2", 1);

        TaskManager.Day = response.day;
        TaskManager.Week = response.week;
        TaskManager.Daily[0] = response.idD0;
        TaskManager.Daily[1] = response.idD1;
        TaskManager.Daily[2] = response.idD2;
        TaskManager.Daily[3] = response.idD3;
        TaskManager.Daily[4] = response.idD4;
        TaskManager.Daily[5] = response.idD5;
        TaskManager.Daily[6] = response.idD6;
        TaskManager.DailyGive[0] = response.idGive0;
        TaskManager.DailyGive[1] = response.idGive1;
        TaskManager.DailyGive[2] = response.idGive2;
        TaskManager.DailyGive[3] = response.idGive3;
        TaskManager.DailyGive[4] = response.idGive4;
        TaskManager.taskProgressDaily = response.taskProgressDaily;

        TaskManager.Weekly[0] = response.idW0;
        TaskManager.Weekly[1] = response.idW1;
        TaskManager.Weekly[2] = response.idW2;
        TaskManager.Weekly[3] = response.idW3;
        TaskManager.Weekly[4] = response.idW4;
        TaskManager.Weekly[5] = response.idW5;
        TaskManager.Weekly[6] = response.idW6;
        TaskManager.WeeklyGive[0] = response.idWGive0;
        TaskManager.WeeklyGive[1] = response.idWGive1;
        TaskManager.WeeklyGive[2] = response.idWGive2;
        TaskManager.WeeklyGive[3] = response.idWGive3;
        TaskManager.WeeklyGive[4] = response.idWGive4;
        TaskManager.taskProgressWeekly = response.taskProgressWeekly;

        IdUnit.idSkin[0] = response.id0Skin;
        IdUnit.idSkin[1] = response.id1Skin;
        IdUnit.idSkin[2] = response.id2Skin;
        IdUnit.idSkin[3] = response.id3Skin;
        IdUnit.idSkin[4] = response.id4Skin;
        IdUnit.idSkin[5] = response.id5Skin;
    }
    public IEnumerator Levels()
    {
        string json = "";
        Dictionary<string, string> form = new Dictionary<string, string> { { "action", "LevelInst" } };
        var cor = Http.HttpQurey(answer => json = answer, "script1", form);
        yield return cor;

        UnitRspone res = JsonUtility.FromJson<UnitRspone>(json);
        IdUnit.idLevel[0] = res.id0Level;
        IdUnit.idLevel[1] = res.id1Level;
        IdUnit.idLevel[2] = res.id2Level;
        IdUnit.idLevel[3] = res.id3Level;
        IdUnit.idLevel[4] = res.id4Level;
        IdUnit.idLevel[5] = res.id5Level;
        IdUnit.idLevel[6] = res.id6Level;
        IdUnit.idLevel[7] = res.id7Level;
        IdUnit.idLevel[8] = res.id8Level;
        IdUnit.idLevel[9] = res.id9Level;
        IdUnit.idLevel[10] = res.id10Level;
        IdUnit.idLevel[11] = res.id11Level;
        IdUnit.idLevel[12] = res.id12Level;
        IdUnit.idLevel[13] = res.id13Level;
        IdUnit.idLevel[14] = res.id14Level;
        IdUnit.idLevel[15] = res.id15Level;
        IdUnit.idLevel[16] = res.id16Level;
        IdUnit.idLevel[17] = res.id17Level;
        IdUnit.idLevel[18] = res.id18Level;
        IdUnit.idLevel[19] = res.id19Level;
        IdUnit.idLevel[20] = res.id20Level;
        IdUnit.idLevel[21] = res.id21Level;
        IdUnit.idLevel[22] = res.id22Level;
        IdUnit.idLevel[23] = res.id23Level;
        IdUnit.idLevel[24] = res.id24Level;
        IdUnit.idLevel[25] = res.id25Level;
        IdUnit.idLevel[26] = res.id26Level;
        IdUnit.idLevel[27] = res.id27Level;
        IdUnit.idLevel[28] = res.id28Level;
        IdUnit.idLevel[29] = res.id29Level;
        IdUnit.idLevel[30] = res.id30Level;
        IdUnit.idLevel[31] = res.id31Level;
        IdUnit.idLevel[32] = res.id32Level;
        IdUnit.idLevel[33] = res.id33Level;
        IdUnit.idLevel[34] = res.id34Level;
        IdUnit.idLevel[35] = res.id35Level;
        IdUnit.idLevel[36] = res.id36Level;
        IdUnit.idLevel[37] = res.id37Level;

        IdUnit.idExp[0] = res.id0Exp;
        IdUnit.idExp[1] = res.id1Exp;
        IdUnit.idExp[2] = res.id2Exp;
        IdUnit.idExp[3] = res.id3Exp;
        IdUnit.idExp[4] = res.id4Exp;
        IdUnit.idExp[5] = res.id5Exp;
        IdUnit.idExp[6] = res.id6Exp;
        IdUnit.idExp[7] = res.id7Exp;
        IdUnit.idExp[8] = res.id8Exp;
        IdUnit.idExp[9] = res.id9Exp;
        IdUnit.idExp[10] = res.id10Exp;
        IdUnit.idExp[11] = res.id11Exp;
        IdUnit.idExp[12] = res.id12Exp;
        IdUnit.idExp[13] = res.id13Exp;
        IdUnit.idExp[14] = res.id14Exp;
        IdUnit.idExp[15] = res.id15Exp;
        IdUnit.idExp[16] = res.id16Exp;
        IdUnit.idExp[17] = res.id17Exp;
        IdUnit.idExp[18] = res.id18Exp;
        IdUnit.idExp[19] = res.id19Exp;
        IdUnit.idExp[20] = res.id20Exp;
        IdUnit.idExp[21] = res.id21Exp;
        IdUnit.idExp[22] = res.id22Exp;
        IdUnit.idExp[23] = res.id23Exp;
        IdUnit.idExp[24] = res.id24Exp;
        IdUnit.idExp[25] = res.id25Exp;
        IdUnit.idExp[26] = res.id26Exp;
        IdUnit.idExp[27] = res.id27Exp;
        IdUnit.idExp[28] = res.id28Exp;
        IdUnit.idExp[29] = res.id29Exp;
        IdUnit.idExp[30] = res.id30Exp;
        IdUnit.idExp[31] = res.id31Exp;
        IdUnit.idExp[32] = res.id32Exp;
        IdUnit.idExp[33] = res.id33Exp;
        IdUnit.idExp[34] = res.id34Exp;
        IdUnit.idExp[35] = res.id35Exp;
        IdUnit.idExp[36] = res.id36Exp;
        IdUnit.idExp[37] = res.id37Exp;

        IdUnit.idGrade[0] = res.id0Grade;
        IdUnit.idGrade[1] = res.id1Grade;
        IdUnit.idGrade[2] = res.id2Grade;
        IdUnit.idGrade[3] = res.id3Grade;
        IdUnit.idGrade[4] = res.id4Grade;
        IdUnit.idGrade[5] = res.id5Grade;
        IdUnit.idGrade[6] = res.id6Grade;
        IdUnit.idGrade[7] = res.id7Grade;
        IdUnit.idGrade[8] = res.id8Grade;
        IdUnit.idGrade[9] = res.id9Grade;
        IdUnit.idGrade[10] = res.id10Grade;
        IdUnit.idGrade[11] = res.id11Grade;
        IdUnit.idGrade[12] = res.id12Grade;
        IdUnit.idGrade[13] = res.id13Grade;
        IdUnit.idGrade[14] = res.id14Grade;
        IdUnit.idGrade[15] = res.id15Grade;
        IdUnit.idGrade[16] = res.id16Grade;
        IdUnit.idGrade[17] = res.id17Grade;
        IdUnit.idGrade[18] = res.id18Grade;
        IdUnit.idGrade[19] = res.id19Grade;
        IdUnit.idGrade[20] = res.id20Grade;
        IdUnit.idGrade[21] = res.id21Grade;
        IdUnit.idGrade[22] = res.id22Grade;
        IdUnit.idGrade[23] = res.id23Grade;
        IdUnit.idGrade[24] = res.id24Grade;
        IdUnit.idGrade[25] = res.id25Grade;
        IdUnit.idGrade[26] = res.id26Grade;
        IdUnit.idGrade[27] = res.id27Grade;
        IdUnit.idGrade[28] = res.id28Grade;
        IdUnit.idGrade[29] = res.id29Grade;
        IdUnit.idGrade[30] = res.id30Grade;
        IdUnit.idGrade[31] = res.id31Grade;
        IdUnit.idGrade[32] = res.id32Grade;
        IdUnit.idGrade[33] = res.id33Grade;
        IdUnit.idGrade[34] = res.id34Grade;
        IdUnit.idGrade[35] = res.id35Grade;
        IdUnit.idGrade[36] = res.id36Grade;
        IdUnit.idGrade[37] = res.id37Grade;

        IdUnit.idOnAnIs[0] = res.id0OnAnIs;
        IdUnit.idOnAnIs[1] = res.id1OnAnIs;
        IdUnit.idOnAnIs[2] = res.id2OnAnIs;
        IdUnit.idOnAnIs[3] = res.id3OnAnIs;
        IdUnit.idOnAnIs[4] = res.id4OnAnIs;
        IdUnit.idOnAnIs[5] = res.id5OnAnIs;
        IdUnit.idOnAnIs[6] = res.id6OnAnIs;
        IdUnit.idOnAnIs[7] = res.id7OnAnIs;
        IdUnit.idOnAnIs[8] = res.id8OnAnIs;
        IdUnit.idOnAnIs[9] = res.id9OnAnIs;
        IdUnit.idOnAnIs[10] = res.id10OnAnIs;
        IdUnit.idOnAnIs[11] = res.id11OnAnIs;
        IdUnit.idOnAnIs[12] = res.id12OnAnIs;
        IdUnit.idOnAnIs[13] = res.id13OnAnIs;
        IdUnit.idOnAnIs[14] = res.id14OnAnIs;
        IdUnit.idOnAnIs[15] = res.id15OnAnIs;
        IdUnit.idOnAnIs[16] = res.id16OnAnIs;
        IdUnit.idOnAnIs[17] = res.id17OnAnIs;
        IdUnit.idOnAnIs[18] = res.id18OnAnIs;
        IdUnit.idOnAnIs[19] = res.id19OnAnIs;
        IdUnit.idOnAnIs[20] = res.id20OnAnIs;
        IdUnit.idOnAnIs[21] = res.id21OnAnIs;
        IdUnit.idOnAnIs[22] = res.id22OnAnIs;
        IdUnit.idOnAnIs[23] = res.id23OnAnIs;
        IdUnit.idOnAnIs[24] = res.id24OnAnIs;
        IdUnit.idOnAnIs[25] = res.id25OnAnIs;
        IdUnit.idOnAnIs[26] = res.id26OnAnIs;
        IdUnit.idOnAnIs[27] = res.id27OnAnIs;
        IdUnit.idOnAnIs[28] = res.id28OnAnIs;
        IdUnit.idOnAnIs[29] = res.id29OnAnIs;
        IdUnit.idOnAnIs[30] = res.id30OnAnIs;
        IdUnit.idOnAnIs[31] = res.id31OnAnIs;
        IdUnit.idOnAnIs[32] = res.id32OnAnIs;
        IdUnit.idOnAnIs[33] = res.id33OnAnIs;
        IdUnit.idOnAnIs[34] = res.id34OnAnIs;
        IdUnit.idOnAnIs[35] = res.id35OnAnIs;
        IdUnit.idOnAnIs[36] = res.id36OnAnIs;
        IdUnit.idOnAnIs[37] = res.id37OnAnIs;

        IdUnit.idSkinWear[0] = res.id0SkinWear;
        IdUnit.idSkinWear[1] = res.id1SkinWear;
        IdUnit.idSkinWear[2] = res.id2SkinWear;
        IdUnit.idSkinWear[3] = res.id3SkinWear;
        IdUnit.idSkinWear[4] = res.id4SkinWear;
        IdUnit.idSkinWear[5] = res.id5SkinWear;
        IdUnit.idSkinWear[6] = res.id6SkinWear;
        IdUnit.idSkinWear[7] = res.id7SkinWear;
        IdUnit.idSkinWear[8] = res.id8SkinWear;
        IdUnit.idSkinWear[9] = res.id9SkinWear;
        IdUnit.idSkinWear[10] = res.id10SkinWear;
        IdUnit.idSkinWear[11] = res.id11SkinWear;
        IdUnit.idSkinWear[12] = res.id12SkinWear;
        IdUnit.idSkinWear[13] = res.id13SkinWear;
        IdUnit.idSkinWear[14] = res.id14SkinWear;
        IdUnit.idSkinWear[15] = res.id15SkinWear;
        IdUnit.idSkinWear[16] = res.id16SkinWear;
        IdUnit.idSkinWear[17] = res.id17SkinWear;
        IdUnit.idSkinWear[18] = res.id18SkinWear;
        IdUnit.idSkinWear[19] = res.id19SkinWear;
        IdUnit.idSkinWear[20] = res.id20SkinWear;
        IdUnit.idSkinWear[21] = res.id21SkinWear;
        IdUnit.idSkinWear[22] = res.id22SkinWear;
        IdUnit.idSkinWear[23] = res.id23SkinWear;
        IdUnit.idSkinWear[24] = res.id24SkinWear;
        IdUnit.idSkinWear[25] = res.id25SkinWear;
        IdUnit.idSkinWear[26] = res.id26SkinWear;
        IdUnit.idSkinWear[27] = res.id27SkinWear;
        IdUnit.idSkinWear[28] = res.id28SkinWear;
        IdUnit.idSkinWear[29] = res.id29SkinWear;
        IdUnit.idSkinWear[30] = res.id30SkinWear;
        IdUnit.idSkinWear[31] = res.id31SkinWear;
        IdUnit.idSkinWear[32] = res.id32SkinWear;
        IdUnit.idSkinWear[33] = res.id33SkinWear;
        IdUnit.idSkinWear[34] = res.id34SkinWear;
        IdUnit.idSkinWear[35] = res.id35SkinWear;
        IdUnit.idSkinWear[36] = res.id36SkinWear;
        IdUnit.idSkinWear[37] = res.id37SkinWear;
    }
}
public class MyData
{
    public int day_change;
    public int week_change;
}
