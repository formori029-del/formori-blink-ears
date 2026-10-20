# FORMORI BLINK EARS (VPM)

![Blink Ears](Website/banner.png)

눈 감는 표정을 지으면 귀가 앞으로 꺾이고 쫑긋하며 꼬리가 살랑 흔들리는 VRChat 아바타 기믹입니다. 윙크하면 그쪽 귀만 움직입니다.
目を閉じる表情で耳が前に倒れてピクッとし、しっぽがゆらゆら揺れる VRChat アバターギミックです。
Ears fold forward and flick, and the tail sways, when an expression closes the eyes.

**유료 툴입니다 / 有料ツールです / Paid tool** — 사용하려면 BOOTH 에서 받은 라이선스 키가 필요합니다. / BOOTH で購入したライセンスキーが必要です。 / Requires the license key from BOOTH.
BOOTH: https://zrpt.booth.pm/

## VCC에 추가 / VCCに追加 / Add to VCC

FORMORI 툴 공용 목록입니다 (Accessory Extractor 와 같은 주소) / FORMORI ツール共通リスト / Shared FORMORI listing

VCC → Settings → Packages → **Add Repository** →

```
https://formori029-del.github.io/formori-accessory-extractor/index.json
```

또는 / または / or: `vcc://vpm/addRepo?url=https://formori029-del.github.io/formori-accessory-extractor/index.json`

프로젝트의 Manage Project 에서 **FORMORI BLINK EARS** 를 추가한 뒤, 아바타를 오른쪽 클릭 → `FORMORI > Blink Ears`. 인스펙터에서 키를 한 번 입력하면 끝입니다.

- 패키지: `Packages/com.formori.blink-ears` (에디터 코드는 DLL)
- 릴리스: 이 저장소 Actions → **Build Release** (package.json 의 version 으로 태그·zip 생성)
- 목록: formori-accessory-extractor 저장소의 **Build Repo Listing** 이 두 저장소의 릴리스를 모아 index.json 게시 (하루 한 번 자동, 바로 반영하려면 수동 실행)
