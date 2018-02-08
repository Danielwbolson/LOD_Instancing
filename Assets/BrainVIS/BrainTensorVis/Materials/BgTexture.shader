Shader "Custom/BgTexture" {
    Properties {
        _Color ("Main Color", Color) = (1,1,1,1)
        _MainTex ("Base (RGB)", 2D) = "white" {}
    }
    Category {
       Lighting Off
       ZWrite Off

       Tags { "Queue" = "Background" }

       SubShader {
            Pass {
			   Cull Off
               
			   SetTexture [_MainTex] {
                    constantColor [_Color]
                    Combine texture * constant, texture * constant 
                 }
            }
        } 
    }
}