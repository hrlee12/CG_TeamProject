Shader "Custom/LowerWorld/ImageEffect/EffectBlend"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _BlendTex ("Blend texture", 2D) = "white" {}
        _Opacity ("Opacity", Range(0, 1)) = 1
    }
    SubShader
    {
        // No culling or depth
        Cull Off ZWrite Off ZTest Always

        Pass
        {
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
            sampler2D _BlendTex;
            float _Opacity;

            fixed4 frag (v2f i) : SV_Target
            {
                fixed4 col = tex2D(_MainTex, i.uv);
                fixed4 blendtex = tex2D(_BlendTex, i.uv);
                // return lerp(col, col * blendtex, _Opacity);
                return lerp(col, col + blendtex, _Opacity);
            }
            ENDCG
        }
    }
}
