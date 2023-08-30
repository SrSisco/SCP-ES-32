


namespace SCP_ES_32
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Exiled.API.Features;
    using Exiled.API.Features.Items;
    using MEC;
    using PlayerRoles;
    using UnityEngine;
    using Random = UnityEngine.Random;

    public class EventHandlers
    {
        private readonly Plugin plugin;
        private static int xpos;
        private static int zpos;

        public EventHandlers(Plugin plugin) => this.plugin = plugin;
        private static string[] nombres = new string[] {"Juan","Miguel","Adolfo"
            , "Cristian","Laura","Lorena","Guillermo","Hernán","Álvaro"
            ,"Jose", "Jesús","Lorenzo","Alberto","????"};

        public static IEnumerator<float> SCP52()
        {
           
            for (; ; )
            {
                if (Round.InProgress == false)
                {
                    yield return Timing.WaitForSeconds(20.0f);
                }
                else
                {
                    xpos = Random.Range(-18, 140);
                    zpos = Random.Range(-53, -29);
                    var i = Random.Range(0, 450);
                    if (i <= 390)
                    {

                    }
                    if (i <= 400 && i >= 391)
                    {
                        Ragdoll.CreateAndSpawn(RoleTypeId.ClassD, nombres[Random.Range(0, nombres.Length)], "Algunos restos humanos, en lo que es mayormente un charco de sangre.", new Vector3(xpos, 1005, zpos), default, null);
                    }
                    if (i > 400)
                    {
                        ItemType[] itemsArray = (ItemType[])Enum.GetValues(typeof(ItemType));
                        List<ItemType> itemList = itemsArray.ToList();
                        itemList.Remove(ItemType.None);
                        itemList.Remove(ItemType.SCP018);
                        itemList.Remove(ItemType.KeycardO5);
                        itemList.Remove(ItemType.SCP244a);
                        itemList.Remove(ItemType.SCP244b);
                        itemList.Remove(ItemType.SCP2176);
                        ItemType item = itemList.RandomItem();

                        Item.Create(item).CreatePickup(new Vector3(xpos, 1005, zpos));
                    }
                    yield return Timing.WaitForSeconds(20.0f);
                }

            }
        }
        internal void OnRoundStarted()
        {
            Timing.RunCoroutine(SCP52(),"scp32");
        }

    }
}
