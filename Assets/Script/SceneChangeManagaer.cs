using UnityEngine;
using UnityEngine.SceneManagement; // シーン切り替えに必要な名前空間

public class SceneChangeManager : MonoBehaviour
{
    // ゲーム本編へ（STARTボタン用）
    public void GoToGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }

    // タイトル画面へ（RETRYボタンやTITLEボタン用）
    public void GoToTitleScene()
    {
        // ※シーン名のスペルに合わせて変更してください（GameSttart / GameStart）
        SceneManager.LoadScene("GameSttart");
    }

    // ゲームオーバー画面へ
    public void GoToGameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

    // ゲームクリア画面へ
    public void GoToGameClear()
    {
        SceneManager.LoadScene("GameClear");
    }

    // インスペクター側で任意のシーン名を直接入力して切り替える汎用メソッド
    public void ChangeSceneByName(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // ゲーム終了ボタン用（ビルド済みアプリのみ機能）
    public void QuitGame()
    {
        Application.Quit();

        // エディタ実行時も再生停止させる処理
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}