Shader "Middle/CatSha"
{
    Properties
    {
        _Color ("Color", Color) = (1,1,1,1)
        _MainTex1 ("Albedo (RGB)", 2D) = "white" {}
        _MainTex2 ("Albedo (RGB)", 2D) = "white" {}
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }

        CGPROGRAM
        #pragma surface surf Standard fullforwardshadows

        sampler2D _MainTex1;
        sampler2D _MainTex2;

        struct Input
        {
            float2 uv_MainTex1;
            float2 uv_MainTex2;
        };

        fixed4 _Color;

        void surf (Input IN, inout SurfaceOutputStandard o)
        {
            fixed4 c = tex2D(_MainTex1, IN.uv_MainTex1) * _Color;
            fixed4 d = tex2D(_MainTex2, IN.uv_MainTex2) * _Color;
            o.Albedo = lerp(c.rgb, d.rgb, d.a);
            o.Alpha = c.a;
        }
        ENDCG
    }
    FallBack "Diffuse"
}
