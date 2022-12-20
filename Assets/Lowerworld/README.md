# 지하, '저승'

## 배경 컨셉
동양풍 저승(극락+지옥) 중 지옥을 중심으로 함  
플레이어는 저승을 구경하는 입장  
저승의 여러 가지 지옥을 씬에 나타낼 것. 전문적이거나 고증에 충실하고자 하는 것은 아니고, 불지옥, 얼음지옥, 칼산지옥 등등 다양한 효과와 애니메이션을 적용할 수 있는 장소면 됨. 아래의 인용을 참고함.  
> 바리공주가 처음 접한 지옥은 십대왕이 남녀죄인 붙들어다 문초하는 지옥이다. 십대왕의 안내로 바리데기가 둘러본 지옥으로 칼산지옥 &#183; 불산지옥 &#183; 눈지옥 &#183; 뱀지옥 &#183; 독사지옥 &#183; 물지옥 &#183; 불지옥 등이 거론되고, 귀졸들이 고문하는 장면도 약간 나온다.  
> \- 참고자료 &#91;4&#93; 「한국지옥 연구-무(巫)의 저승」(조흥윤,『샤머니즘 연구』 창간호,한국샤머니즘학회,문덕사,1999)에서 발췌

## 씬 구성
플레이어는 저승의 입구에서 시작. 큰 대문을 지나가면 차례대로 여러 망자가 줄을 서서 심판을 기다리는 곳, 불지옥, 물지옥(구현 능력에 따라 얼음지옥으로 대체될 수 있음), 칼산지옥 등을 구경할 수 있다. 지옥의 끝에 이르면 천상과 지상으로 갈 수 있는 길이 나온다(장식이지만 진행 상황에 따라 실제 이동 기능 부여 가능).  

<figure style="text-align: center">
    <img src="https://user-images.githubusercontent.com/89961651/203311148-d28bd375-89c0-4419-bf28-afdff9aba94c.png" alt="[이미지] 지하 씬 구상">
    <figcaption style="text-align: center">[이미지] 지하 씬 구상</figcaption>
</figure>

## 구현 기능
**대문으로 입장하여 왼쪽 앞 붉은 영역은 불지옥, 오른쪽 앞 푸른 영역은 얼음지옥, 왼쪽 뒤 높은 산 지형은 칼산지옥.**  
  
- 화면 전체 UI : 중앙에 마우스 포인터(단순 이미지), 우상단 미니맵. `I`를 누르면 씬의 구성요소에 대한 정보 확인 가능
- 플레이어 : 머리 위에 미니맵 아이콘 있음, 외부 에셋을 이용한 모델 부여(카메라에는 보이지 않음)
- 지형 : 총 5가지 Terrain Layer 사용, 노란 길은 평지(높이 52), 세 가지 지옥의 높이를 조절해 울퉁불퉁하게 만들었고, 길의 끝에 있는 갈림길에서 smooth 사용
- 대문 앞 망자들 : 흑백 셰이더 적용
- 대문(`BigFrontDoor.prefab`) : 자동문 기능(회전, 애니메이션 재생 순서 컨트롤)
- 대문 기둥(`Tree.mat`) : 인스펙터 통한 밝기 조절 기능, 기본값 -0.12
- 불지옥 : 3D 사운드 효과 추가
- 불지옥 불꽃(`RedFlame.prefab`, `YellowFlame.prefab`) : 서로 다른 두 이미지를 합친 불꽃 셰이더(5주차B 강의자료 참고). 붉은색과 노란색 불꽃의 셰이더가 서로 다름.
- 얼음지옥 얼음(`IceCube.prefab`) : NormalMap, Lerp 적용. 수업시간에 배우지 않았으나 필요해서 반투명하게 만듦
- 칼산지옥 칼날(`Blade.prefab`) : Metal, Smooth 셰이더 적용
- 전망대(`ViewPoint`) : Invert, Gray, Blend, Overlay 네 가지 이미지 이펙트 셰이더 체험 가능(미니맵에 적용)
- 갈림길 : 메쉬스크립트로 생성한 다이아몬드, 바닥에 씬 이동 스크립트 적용된 콜라이더
- 프리펩 : 대문, 불지옥 불꽃, 얼음지옥 얼음, 칼산지옥 칼날, FPS캐릭터

## 구현 및 오류 해결 참고 자료
- &#91;1&#93; #3 에임위에 있는 오브젝트 이름 출력 &#91;Raycast&#93; (6/6), <a href="https://coding-server.tistory.com/m/7" target="_blank">https://coding-server.tistory.com/m/7</a>
- &#91;2&#93; &#91;Unity 2020.3 LTS&#93; TextMeshPro 한글 네모로 출력 해결, <a href="https://blaupowder.tistory.com/107" target="_blank">https://blaupowder.tistory.com/107</a>  
- &#91;3&#93; 유니티에서 gameObject가 비활성인지 확인 및 이벤트., <a href="https://boxwitch.tistory.com/entry/%EC%9C%A0%EB%8B%88%ED%8B%B0-gameObject-%ED%99%9C%EC%84%B1-activeSelf" target="_blank">https://boxwitch.tistory.com/entry/유니티-gameObject-활성-activeSelf</a>
- &#91;4&#93; Unity Shader - Alpha 이론 & 문제 해결, <a href="https://darkcatgame.tistory.com/31" target="_blank">https://darkcatgame.tistory.com/31</a>

## 컨셉 참고 자료
- &#91;1&#93; 한국민족문화대백과사전(저승설화(─說話)), <a href="http://encykorea.aks.ac.kr/Contents/Item/E0049101" target="_blank">http://encykorea.aks.ac.kr/Contents/Item/E0049101</a>  
- &#91;2&#93; 피처 &#124; &#91;ODD NOTES&#93; 동서양의 사후세계 &#91;No.142&#93;, <a href="https://www.themusical.co.kr/Magazine/Detail?enc_num=Xwi5WvzQtZMz%2BVoVuUUFbQ%3D%3D" target="_blank">https://www.themusical.co.kr/Magazine/Detail?enc_num=Xwi5WvzQtZMz%2BVoVuUUFbQ%3D%3D</a>  
- &#91;3&#93; &#91;취재파일&#93; 저승사자는 정말 3인조일까?, <a href="https://news.sbs.co.kr/news/endPage.do?news_id=N1004572254" target="_blank">https://news.sbs.co.kr/news/endPage.do?news_id=N1004572254</a>  
- &#91;4&#93; 「한국지옥 연구-무(巫)의 저승」(조흥윤,『샤머니즘 연구』 창간호,한국샤머니즘학회,문덕사,1999)
