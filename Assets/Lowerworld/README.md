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
- `BigFrontDoor` 오브젝트에 자동문 기능 구현
- `RedFlame`, `YellowFlame` 프리펩 생성 : 서로 다른 두 이미지를 합쳐 보여주는 셰이더 적용. **강의자료 5주차B 참고했으나 구현 요구사항 중 어느 항목에 해당하는지 몰라 표시하지 않았음**
- 미니맵 구현
- `Terrain`에 서로 다른 3가지 이상의 Texture 적용
- `Terrain`에 높이가 일정한 평지, 높이가 smooth된 지형, 브러시를 이용해 높낮이를 수정한 지형 존재
- `Blade` 프리펩에 Metal, Smooth 셰이더 적용

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
