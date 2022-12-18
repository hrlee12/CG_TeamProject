Shader "Custom/Lowerworld/NormalMapLerp"
{
    Properties
    {
        _Color ("Color", Color) = (1,1,1,1)
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
        _MainTex2 ("Albedo2 (RGB)", 2D) = "white" {}
        _NormalMap ("NormalMap(Bump)", 2D) = "bump" {}
        _LerpRange ("Lerp Range", Range(0, 1)) = 0.5
        _Glossiness ("Smoothness", Range(0,1)) = 0.5
        _Alpha ("Alpha", range(0, 1)) = 1
    }
    SubShader
    {
        Tags { "RenderType"="Transparent" "Queue"="Transparent" }
        blend SrcAlpha OneMinusSrcAlpha

        CGPROGRAM
        #pragma surface surf Standard fullforwardshadows alpha:fade keepalpha

        sampler2D _MainTex;
        sampler2D _MainTex2;
        sampler2D _NormalMap;

        struct Input
        {
            float2 uv_MainTex;
            float2 uv_MainTex2;
            float2 uv_NormalMap;
        };

        half _Glossiness;
        fixed4 _Color;
        float _LerpRange;
        float _Alpha;

        void surf (Input IN, inout SurfaceOutputStandard o)
        {
            fixed4 c = tex2D (_MainTex, IN.uv_MainTex);
            fixed4 d = tex2D (_MainTex2, IN.uv_MainTex2) * _Color;
            o.Albedo = lerp(c.rgb, d.rgb, _LerpRange);
            o.Smoothness = _Glossiness;
            o.Alpha = _Alpha;

            fixed3 normap = UnpackNormal(tex2D (_NormalMap, IN.uv_NormalMap));
            o.Normal = normap;
        }
        ENDCG
    }
    FallBack "Diffuse"
}
