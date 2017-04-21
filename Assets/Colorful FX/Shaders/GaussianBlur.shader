﻿// Colorful FX - Unity Asset
// Copyright (c) 2015 - Thomas Hourdel
// http://www.thomashourdel.com

Shader "Hidden/Colorful/Gaussian Blur"
{
	Properties
	{
		_MainTex ("Base (RGB)", 2D) = "white" {}
		_Direction ("Direction (XY)", Vector) = (0, 0, 0, 0)
		_Amount ("Blend factor (Float)", Float) = 1.0
	}

	SubShader
	{
		ZTest Always Cull Off ZWrite Off
		Fog { Mode off }

		// (0) Blur
		Pass
		{
			CGPROGRAM
				#pragma vertex vert
				#pragma fragment frag
				#pragma fragmentoption ARB_precision_hint_fastest 
				#include "UnityCG.cginc"

				sampler2D _MainTex;
				half2 _Direction;

				struct fInput
				{
					float4 pos : SV_POSITION;
					float2 uv : TEXCOORD0;
					float4 uv1 : TEXCOORD1;
					float4 uv2 : TEXCOORD2;
				};

				fInput vert(appdata_img v)
				{
					fInput o;
					o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
					o.uv = v.texcoord.xy;
					float2 d1 = 1.3846153846 * _Direction;
					float2 d2 = 3.2307692308 * _Direction;
					o.uv1 = float4(o.uv + d1, o.uv - d1);
					o.uv2 = float4(o.uv + d2, o.uv - d2);
					return o;
				}

				half4 frag(fInput i) : SV_Target
				{
					half4 oc = tex2D(_MainTex, i.uv);
					half3 c = oc.rgb * 0.2270270270;
					c += tex2D(_MainTex, i.uv1.xy).rgb * 0.3162162162;
					c += tex2D(_MainTex, i.uv1.zw).rgb * 0.3162162162;
					c += tex2D(_MainTex, i.uv2.xy).rgb * 0.0702702703;
					c += tex2D(_MainTex, i.uv2.zw).rgb * 0.0702702703;
					return half4(c, oc.a);
				}

			ENDCG
		}

		// (1) Composite if _Amount is in ]0;1[
		Pass
		{
			CGPROGRAM
				#pragma vertex vert_img
				#pragma fragment frag
				#pragma fragmentoption ARB_precision_hint_fastest 
				#include "UnityCG.cginc"

				sampler2D _MainTex;
				sampler2D _Blurred;
				half _Amount;

				half4 frag(v2f_img i) : SV_Target
				{
					half4 oc = tex2D(_MainTex, i.uv);
					half4 bc = tex2D(_Blurred, i.uv);
					return lerp(oc, bc, _Amount);
				}

			ENDCG
		}
	}

	FallBack off
}
