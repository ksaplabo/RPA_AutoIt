#cs ----------------------------------------------------------------------------

 AutoIt Version: 3.3.14.5
 Author:         myName

 Script Function:
	Template AutoIt script.

#ce ----------------------------------------------------------------------------

; Script Start - Add your code below here

;## 初期設定 ##
;ウィンドウタイトル照合モード : 部分一致
AutoItSetOption("WinTitleMatchMode",2)
;アプリ起動
run(".\WinApp.exe")
;アプリが起動するまでウエイト
WinWait("メイン画面","")

;## 操作開始 ##
;「ファイルパス」入力
ControlSetText("メイン画面","","[CLASS:WindowsForms10.EDIT.app.0.141b42a_r9_ad1;INSTANCE:2]","notExistFile.txt")

;(デモ用ウエイト)
Sleep(1000)

;「ファイルパス」参照ボタンクリック
ControlClick("メイン画面","","[CLASS:WindowsForms10.BUTTON.app.0.141b42a_r9_ad1;INSTANCE:2]")

;ウィンドウが表示されるまでウエイト
WinWait("編集するファイルを選択してください。","")

;(デモ用ウエイト)
Sleep(2000)

;「キャンセル」クリック
ControlClick("[CLASS:#32770]","","[CLASS:Button;INSTANCE:2]")

;(デモ用ウエイト)
Sleep(1000)

;「ファイルパス」再入力
ControlSetText("メイン画面","","[CLASS:WindowsForms10.EDIT.app.0.141b42a_r9_ad1;INSTANCE:2]","sample_memo.txt")

;「ファイルパス」フォーカス設定
ControlFocus("メイン画面","","[CLASS:WindowsForms10.EDIT.app.0.141b42a_r9_ad1;INSTANCE:2]")

;(デモ用ウエイト)
Sleep(1000)

;「ファイルパス」TABキー入力 → 内容表示
ControlSend("メイン画面","","[CLASS:WindowsForms10.EDIT.app.0.141b42a_r9_ad1;INSTANCE:2]","{TAB}")

;(デモ用ウエイト)
Sleep(1000)

;「ファイルパス」フォーカス設定
ControlFocus("メイン画面","","[CLASS:WindowsForms10.EDIT.app.0.141b42a_r9_ad1;INSTANCE:1]")

;「↓」押下
ControlSend("メイン画面","","[CLASS:WindowsForms10.EDIT.app.0.141b42a_r9_ad1;INSTANCE:1]","{DOWN}")

;「ファイル内容」追記
ControlSetText("メイン画面","","[CLASS:WindowsForms10.EDIT.app.0.141b42a_r9_ad1;INSTANCE:1]","追加文章記入…やっぱやめます。取消ぽちっとしてから終了します。")

;(デモ用ウエイト)
Sleep(2000)

;「取消」クリック
ControlClick("メイン画面","","[CLASS:WindowsForms10.BUTTON.app.0.141b42a_r9_ad1;INSTANCE:1]")

;(デモ用ウエイト)
Sleep(1000)

;「終了」クリック
ControlClick("メイン画面","","[CLASS:WindowsForms10.BUTTON.app.0.141b42a_r9_ad1;INSTANCE:4]")

MsgBox(1,"AutoIt","以上でデモ終了です！")
