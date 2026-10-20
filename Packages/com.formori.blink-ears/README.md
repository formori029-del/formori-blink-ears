# FORMORI BLINK EARS

**한국어** · [日本語](#日本語) · [English](#english)

눈을 감는 표정을 지으면 귀가 앞으로 꺾이고 쫑긋하며, 꼬리가 살랑 흔들리는 기믹입니다. 윙크하면 감은 쪽 귀만 움직입니다.
업로드할 때 자동으로 만들어지므로 아바타 원본은 바뀌지 않습니다.

## 필요한 것

- Unity 2022.3 / VRChat SDK Avatars 3.7 이상
- NDMF 1.7 이상, Modular Avatar 1.10 이상

## 설치

1. VCC 에서 프로젝트에 **NDMF** 와 **Modular Avatar** 를 먼저 넣습니다.
2. `FORMORI-BlinkEars-v1.0.0.unitypackage` 를 Unity 에 끌어다 놓아 임포트합니다. (`Packages/com.formori.blink-ears` 에 들어갑니다)

## 쓰는 법

1. Hierarchy 에서 아바타를 오른쪽 클릭 → `FORMORI > Blink Ears` (또는 메뉴 `Tools > FORMORI > Blink Ears`).
2. 인스펙터 맨 위가 **✓ 준비 완료** 면 그대로 업로드하면 끝입니다.
3. 반응(졸린 귀 / 쫑긋 / 꼬리 내리기 / 살랑)은 켜고 끄기만 하면 되고, 세기는 각 카드 안에서 바꿉니다.
4. **미리보기**의 두 눈 감기 / 왼쪽 윙크 / 오른쪽 윙크로 씬에서 자세를 확인할 수 있습니다.

게임 안 Expression 메뉴에 **귀·꼬리 반응** 켜기/끄기가 추가됩니다 (동기화 파라미터 1비트).

## 어떤 표정에 반응하나요

- 아바타 기본 표정(손 제스처), FaceEmo('아바타에 적용' 후), Modular Avatar 로 넣는 표정·페이스 트래킹 프리팹을 자동으로 읽습니다.
- 표정 이름이 아니라 눈꺼풀이 움직이는 모양으로 판별합니다. 웃는 눈처럼 덜 감기면 덜 반응합니다.
- 원하는 쉐이프키만 쓰고 싶으면 **반응할 표정 → 쉐이프키 직접 지정**에서 두 눈 / 왼쪽 눈 / 오른쪽 눈 키를 고릅니다.
- VRChat 기본 깜빡임에는 반응하지 않습니다 (아바타 애니메이터가 깜빡임을 읽을 방법이 없습니다).
- VRCFury 로 넣은 표정, 텍스처로 눈을 바꾸는 표정은 자동으로 잡히지 않습니다. 텍스처 표정은 세부 설정에서 직접 넣을 수 있습니다.

## 문제가 있을 때

- 귀가 안 움직이면: 인스펙터 **귀·꼬리**에서 본이 체크되어 있는지 확인하세요. 귀·꼬리의 PhysBone 은 빌드 때 자동으로 Is Animated 가 켜집니다.
- 반응할 표정이 0개면: FaceEmo 는 '아바타에 적용'을 먼저 해 주세요.

---

## 日本語

目を閉じる表情をすると耳が前に倒れてピクッとし、しっぽがゆらゆら揺れるギミックです。ウインクすると閉じた側の耳だけが動きます。
アップロード時に自動で作られるので、アバター本体は変更されません。

**必要なもの:** Unity 2022.3 / VRChat SDK Avatars 3.7 以上 / NDMF 1.7 以上 / Modular Avatar 1.10 以上

**導入:** VCC で NDMF と Modular Avatar を入れてから、`.unitypackage` をインポートします(`Packages/com.formori.blink-ears` に入ります)。

**使い方**

1. Hierarchy でアバターを右クリック → `FORMORI > Blink Ears`(またはメニュー `Tools > FORMORI > Blink Ears`)。
2. インスペクター上部が **✓ 準備完了** ならそのままアップロードで完了です。
3. 反応(眠い耳 / ピクッ / しっぽを下げる / ゆらゆら)はオン・オフだけ。強さは各カード内で変えられます。
4. **プレビュー**の 両目を閉じる / 左ウインク / 右ウインク でシーン上の姿勢を確認できます。

Expression メニューに **耳・しっぽ反応** の ON/OFF が追加されます(同期パラメーター 1 ビット)。

- アバター標準の表情(ハンドジェスチャー)、FaceEmo(「アバターに適用」後)、Modular Avatar で入れる表情・フェイストラッキングプレハブを自動で読みます。
- 表情の名前ではなく、まぶたの動きの形で判定します。使うシェイプキーを決めたい場合は **反応する表情 → シェイプキー手動指定** で両目 / 左目 / 右目のキーを選べます。
- VRChat の自動まばたき、VRCFury で入れた表情、テクスチャで目を変える表情は自動では反応しません。

---

## English

When an expression closes the eyes, the ears fold forward and flick, and the tail sways. A wink moves only that side's ear.
Everything is generated on upload, so your avatar itself is not modified.

**Requirements:** Unity 2022.3 / VRChat SDK Avatars 3.7+ / NDMF 1.7+ / Modular Avatar 1.10+

**Install:** add NDMF and Modular Avatar with VCC, then import the `.unitypackage` (it goes to `Packages/com.formori.blink-ears`).

**How to use**

1. Right-click your avatar in the Hierarchy → `FORMORI > Blink Ears` (or `Tools > FORMORI > Blink Ears`).
2. If the top of the Inspector says **✓ Ready**, just upload.
3. Switch reactions (Sleepy ears / Twitch / Tail down / Wag) on or off; adjust strength inside each card.
4. Use **Preview** (Both eyes / Left wink / Right wink) to check the pose in the Scene view.

An **Ear & Tail Reaction** on/off toggle is added to the Expression menu (1 synced bit).

- Reads the avatar's own gesture expressions, FaceEmo (after "Apply to avatar"), and expressions or face-tracking prefabs added with Modular Avatar.
- Detection is based on how the eyelids move, not on names. To choose the keys yourself, use **Which expressions → Pick shape keys** (both / left / right eye).
- VRChat's automatic blinking, expressions added through VRCFury, and texture-based eyes are not picked up automatically.
