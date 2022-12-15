Shader "midterm/outdoors/warterfall"
{
    Properties
    {
        _MainTex1 ("Albedo (RGB)", 2D) = "white" {}
        _MainTex2 ("Albedo (RGB)", 2D) = "white" {}
    }
    SubShader
    {
        Tags { "RenderType"="Transparent" "Queue"="Transparent" }
        
        CGPROGRAM
        #pragma surface surf Standard fullforwardshadows alpha:fade // fade: 투명하게

        sampler2D _MainTex1;
        sampler2D _MainTex2;

        struct Input
        {
            float2 uv_MainTex1;
            float2 uv_MainTex2;
        };


        void surf (Input IN, inout SurfaceOutputStandard o)
        {
            fixed4 c = tex2D(_MainTex1, IN.uv_MainTex1);
            fixed4 d = tex2D(_MainTex2, float2(IN.uv_MainTex2.x, +IN.uv_MainTex2.y + _Time.y));
            o.Emission = c.rgb * d.rgb;
            o.Alpha = c.a * 0.8;
        }
        ENDCG
    }
    FallBack "Diffuse"
}
