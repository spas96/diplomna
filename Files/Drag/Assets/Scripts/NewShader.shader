Shader "Custom/NewShader" {
	Properties {
		_MainTex ("Texture", 2D) = ""
	}
	SubShader {
		Ztest Always
		Tags {Queue = Transperent}
	//	Queue = }
		Pass
		{
			//Offset -1,-1
			SetTexture[_MainTex] {Combine texture }
		}
		
	
	} 
	
}
