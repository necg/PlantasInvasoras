﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateNamespace;
namespace PlantNamespace {

    public abstract class Plant : MonoBehaviour {
		
		protected StageManager manager; // So I can alter the managers state
        public GameObject mainCamera;
        protected SoundEffectsManager soundManager;

        public enum PlantState {
			DRYING, WATERED, BURNING, DYING // Add here more states you need
		}

        protected PlantState currentState;

        public void Start() {
            mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
            soundManager = GameObject.Find("SoundEffectsManager").GetComponent<SoundEffectsManager>();
            initializeVariables();
            
        }

        public void Update()  {
			updatePlantState();
        }

        public void DeSpawn()
        {
            gameObject.SetActive(false);
        }

		public abstract void updatePlantState();
        public abstract void bombed(float impact);
        public abstract void burnt();
        public abstract void cut();
        public abstract void caught();
        public abstract void Touch();
        public abstract void initializeVariables();

        // Dying coroutine
        public abstract IEnumerator Die();
    }
}
