Shader "Hidden/NewImageEffectShader"
{
	//uniform float radius_of_vignette;

    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
		_radius_of_vignette("_radius_of_vignette", float) = 2.1
    }
    SubShader
    {
        // No culling or depth
        Cull Off ZWrite Off ZTest Always

		Tags{
			"Queue" = "Transparent"
		}

        Pass
        {
			Blend SrcAlpha OneMinusSrcAlpha

            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                return o;
            }

            sampler2D _MainTex;
			uniform float _radius_of_vignette;

            float4 frag (v2f input) : SV_Target
            {
				float4 base = tex2D(_MainTex, input.uv);
                // just invert the colors
				float distFromCenter = _radius_of_vignette *distance(input.uv.xy, float2(0.5, 0.5));
				float vingette = 1 - distFromCenter;
				base = saturate(base * vingette);
				return base; 
                //col.rgb = 1 - col.rgb;
                //return float4(1, 1, 1, 1);
            }
            ENDCG
        }
    }
}
