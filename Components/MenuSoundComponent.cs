using ShamanMod.Modules;
using RoR2;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    public class MenuSoundComponent : MonoBehaviour
    {
        private uint playID1 = 0;

        private void OnEnable()
        {                              //Sounds.CharSelect
                    //presto! frame / framerate * animation speed in animator state 
            StartCoroutine(delayedGunSound(1f / 24f, "ShamanLobby2"));
        }

    private IEnumerator delayedGunSound(float delay, string playedSound)
    {
        yield return new WaitForSeconds(delay);
        if (playedSound == "ShamanLobby2")
        {
            this.playID1 = Util.PlaySound(playedSound, base.gameObject);
        }
    }

        private void OnDestroy()
        {
            if (this.playID1 != 0) AkSoundEngine.StopPlayingID(this.playID1);
        }
    }
