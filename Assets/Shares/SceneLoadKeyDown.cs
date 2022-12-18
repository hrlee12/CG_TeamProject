using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoadKeyDown : MonoBehaviour
{
    public Object UpperworldScene;
    public Object MiddleworldScene;
    public Object LowerworldScene;
    Scene CurrentScene;
    int NowSceneIndex;

    void Start()
    {
        print("SceneLoadKeyDown script start"); // 콘솔 확인용 출력문 : 씬을 플레이할 때 어떤 스크립트가 실행되었는지 나타냄
        NowSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    void Update()
    {
        // 현재 있는 씬으로 이동하는 키를 눌렀을 경우 씬 전환 안 되게 함
        // 유니티 키 코드 참고 : https://docs.unity3d.com/kr/2021.3/ScriptReference/KeyCode.html
        // 단축키 조합 : Ctrl + 1, 2, 3
        // 키보드 위쪽 숫자 키, 숫자 패드 숫자 키 모두 가능
        // 좌우 컨트롤 키 모두 가능
        if ((Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))
            && (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1)))
        {
            if (NowSceneIndex != 0)
            {
                print("go to Upperworld");
                SceneManager.LoadScene(0);
            }
        }
        if ((Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))
            && (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2)))
        {
            if (NowSceneIndex != 1)
            {
                print("go to Middleworld");
                SceneManager.LoadScene(1);
            }
        }
        if ((Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))
            && (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3)))
        {
            if (NowSceneIndex != 2)
            {
                print("go to Lowerworld");
                SceneManager.LoadScene(2);
            }
        }
    }
}
