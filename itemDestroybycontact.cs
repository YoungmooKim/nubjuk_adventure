﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemDestroybycontact : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		if (other.tag == "phone" || other.tag=="book"|| other.tag=="hotsix"|| other.tag=="soju"|| other.tag=="dumbel"){
			return;
		}
		audiomanager.PlaySound("item");
		Destroy(this.gameObject);
	}

}
