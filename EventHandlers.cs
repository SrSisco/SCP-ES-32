using System;
using System.Collections.Generic;
using System.Linq;
using Exiled.API.Features;
using Exiled.API.Features.Items;
using Exiled.Events.EventArgs.Server;
using MEC;
using PlayerRoles;
using UnityEngine;
using Random = UnityEngine.Random;

namespace SCP_ES_32
{
    public class EventHandlers
    {
        private static IEnumerator<float> ScpEs32()
        {
            for (; ; )
            {
                var xpos = Random.Range(-18, 140);
                var zpos = Random.Range(-53, -29);
                var itemRandom = Random.Range(0, 100);
                var ragdollRandom = Random.Range(0, 100);
                
                
                //Spawn random ragdoll from config list
                if (ragdollRandom > SCP_ES_32.Instance.Config.RagdollProbability && SCP_ES_32.Instance.Config.RagdollSpawn)
                {
                    
                    Ragdoll.CreateAndSpawn(RoleTypeId.ClassD, SCP_ES_32.Instance.Config.RagdollNames[Random.Range(0, SCP_ES_32.Instance.Config.RagdollNames.Count)]
                        , SCP_ES_32.Instance.Config.RagdollDeaths.RandomItem(), new Vector3(xpos, 1005, zpos), default, null);
                }
                
                //Spawn random item from config list
                if (itemRandom > SCP_ES_32.Instance.Config.ItemProbability && SCP_ES_32.Instance.Config.ItemSpawn)
                {
                    ItemType item = SCP_ES_32.Instance.Config.Spawnable_Items.RandomItem();

                    Item.Create(item).CreatePickup(new Vector3(xpos, 1005, zpos));
                }
                
                yield return Timing.WaitForSeconds(SCP_ES_32.Instance.Config.TimeBetweenSpawns);
            }
        }
        
        internal void OnRoundEnded(RoundEndedEventArgs ev)
        {
            Timing.KillCoroutines("scp32");
        }
        internal void OnRoundStarted()
        {
            Timing.RunCoroutine(ScpEs32(),"scp32");
        }
    }
}