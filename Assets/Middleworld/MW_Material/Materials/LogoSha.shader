Shader "Middle/LogoSha"
{
    Properties
    {
        _Color("Color", Color) = (1,1,1,1)
        _MainTex("Albedo (RGB)", 2D) = "white" {}
    }
        SubShader
    {
        Tags { "RenderType" = "Opaque" }

        // 1pass
        cull front
        CGPROGRAM
        #pragma surface surf NoLight vertex:vert noambient noshadow

        sampler2D _MainTex;

        struct Input
        {
            float2 uv_MainTex;
        };
        void vert(inout appdata_full v) {
            v.vertex.xyz += v.normal.xyz * 0.5;
        }

        void surf(Input IN, inout SurfaceOutput o)
        {
            fixed4 c = tex2D(_MainTex, IN.uv_MainTex);
            o.Albedo = c.rgb;
            o.Alpha = c.a;
        }

        float4 LightingNoLight(SurfaceOutput s, float3 lightDir, float atten) {
            return float4(0, 0, 0, 1); // 검은색(외곽선)
        }
        ENDCG

        // 2pass
        cull back // 다시 돌리기
        CGPROGRAM
        #pragma surface surf Lambert

        sampler2D _MainTex;

        struct Input
        {
            float2 uv_MainTex;
        };
        fixed4 _Color;
        void surf(Input IN, inout SurfaceOutput o)
        {
            fixed4 c = tex2D(_MainTex, IN.uv_MainTex) * _Color;
            o.Albedo = c.rgb;
            o.Alpha = c.a;
        }
        ENDCG

    }
        FallBack "Diffuse"
}
