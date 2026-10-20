using System;
using System.Collections.Generic;
using UnityEngine;

namespace Formori.BlinkEars
{
    /// <summary>
    /// 아바타 안에 하나 두면 빌드 때 눈 감는 표정 클립을 찾아 신호를 넣고, 그 신호로 귀·꼬리를 움직이는 FX 레이어를 만든다.
    /// 아바타의 눈꺼풀 설정·본 구조는 바꾸지 않는다.
    /// </summary>
    [DisallowMultipleComponent]
    [AddComponentMenu("FORMORI/Blink Ears")]
    public class BlinkEars : MonoBehaviour, VRC.SDKBase.IEditorOnly
    {
        // ── 반응 (프리셋은 이 값들을 켜고 끈다) ──
        [Tooltip("눈을 감고 있는 동안 귀를 앞으로 꺾는다")]
        public bool sleepyEars = true;
        [Range(0f, 80f)] public float earAngle = 50f;
        [Tooltip("켜면 앞이 아니라 뒤로 눕힌다")]
        public bool earsBack;
        [Tooltip("눈을 감는 순간 귀가 한 번 파르르 떤다")]
        public bool twitch = true;
        [Range(0f, 30f)] public float twitchAngle = 12f;
        [Tooltip("눈을 감고 있는 동안 꼬리를 내린다")]
        public bool tailDown = true;
        [Range(0f, 60f)] public float tailDownAngle = 15f;
        [Tooltip("눈을 감고 있는 동안 꼬리를 느리게 흔든다")]
        public bool tailWag = true;
        [Range(0f, 45f)] public float tailWagAngle = 15f;
        [Range(0.2f, 3f)] public float tailWagSpeed = 0.5f;
        [Tooltip("귀·꼬리가 따라오는 시간(초). 길수록 늦게 천천히 움직인다")]
        [Range(0.05f, 1f)] public float followTime = 0.25f;

        // ── 귀·꼬리 본 ──
        [Tooltip("추가할 때 자동으로 채워지며 직접 고칠 수 있다")]
        public List<Transform> earBones = new List<Transform>();
        public List<Transform> tailBones = new List<Transform>();
        /// <summary>자동 탐지를 한 번 했는지 (사용자가 고친 목록을 덮어쓰지 않기 위해)</summary>
        public bool detected;

        // ── 눈 감는 표정 판별 ──
        [Tooltip("비우면 아바타 디스크립터의 눈꺼풀 메시(없으면 Viseme 메시)")]
        public SkinnedMeshRenderer faceMesh;
        [Tooltip("비우면 디스크립터의 눈꺼풀 Blink 쉐이프키. 판별의 기준이 되는 '눈 감기' 쉐이프키")]
        public string blinkShape = "";
        [Tooltip("켜면 자동 판별 대신 아래 목록의 쉐이프키만 '눈 감기'로 본다")]
        public bool manualShapes;
        [Tooltip("100% 면 두 눈이 다 감기는 쉐이프키")]
        public List<string> bothEyeShapes = new List<string>();
        [Tooltip("100% 면 아바타의 왼쪽 눈이 감기는 쉐이프키")]
        public List<string> leftEyeShapes = new List<string>();
        [Tooltip("100% 면 아바타의 오른쪽 눈이 감기는 쉐이프키")]
        public List<string> rightEyeShapes = new List<string>();
        [Tooltip("이 정도 이상 감기면 '눈을 감았다'로 본다 (Blink 100% = 1)")]
        [Range(0.2f, 1f)] public float threshold = 0.6f;
        [Tooltip("한쪽 눈만 감는 윙크에도 반응한다 (감은 쪽 귀만). 끄면 두 눈이 다 감겨야 반응")]
        public bool reactToWink = true;
        [Tooltip("자동 판별에서 뺄 클립 이름")]
        public List<string> excludedClips = new List<string>();
        [Tooltip("쉐이프키가 아닌 방법(텍스처 등)으로 눈을 감는 표정은 여기에 직접 넣는다")]
        public List<ManualClip> manualClips = new List<ManualClip>();

        // ── 메뉴 ──
        public bool installMenu = true;
        [Tooltip("비우면 에디터 언어에 맞춰 귀·꼬리 반응 / 耳・しっぽ反応 / Ear & Tail Reaction")]
        public string menuName = "";

        [Serializable]
        public class ManualClip
        {
            public AnimationClip clip;
            [Range(0f, 1f)] public float closed = 1f;
        }
    }
}
