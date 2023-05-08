import tkinter as tk

root = tk.Tk()
root.title("簡易60%鍵盤檢測工具")

#label容器
key_labels = []
#每行按鍵數
keyboardLen = [12, 13, 13, 13, 12, 11]
row_count, col_count = 0 , 0

#keysym的按鍵命名
key_lists = ['escape','f1','f2','f3','f4','f5','f6','f7','f8','f9','f10','f11','f12',
            'grave','1','2','3','4','5','6','7','8','9','0','minus','equal','backspace',
            'tab','q','w','e','r','t','y','u','i','o','p','bracketleft','bracketright','backslash',
            'caps_lock','a','s','d','f','g','h','j','k','l','semicolon','apostrophe','return',
            'shift_l','z','x','c','v','b','n','m','comma','period','slash','shift_r',
            'control_l','win_l','alt_l','space','alt_r','app','control_r']

#實際鍵盤按鍵
key_names = ['Esc','F1','F2','F3','F4','F5','F6','F7','F8','F9','F10','F11','F12',
            '`','1','2','3','4','5','6','7','8','9','0','-','=','BackSpace',
            'Tab','Q','W','E','R','T','Y','U','I','O','P','[',']','\\',
            'Caps_LK','A','S','D','F','G','H','J','K','L',';','\'','Enter',
            'Shift','Z','X','C','V','B','N','M',',','.','/','Shift',
            'Control','Win','Alt','Space','Alt','Menu','Control']

#需要加長的鍵
long_keys = ['BackSpace','Caps_LK','Enter','Shift']

#檢測按下
def on_press(event):
    if event.keysym.lower() in key_lists:
        key_labels[key_lists.index(event.keysym.lower())].config(bg='skyblue')

#檢測放開
def on_release(event):
    if event.keysym.lower() in key_lists:
        key_labels[key_lists.index(event.keysym.lower())].config(bg='gray')

#建立鍵盤：以一般鍵，長鍵（兩倍寬），及Space（六倍寬）區分
for ele in key_names:
    if ele in long_keys:
        key_label = tk.Label(root, text=ele, relief="raised", width=17, height=3)
        key_label.grid(row=row_count, column=col_count, columnspan=2, sticky=tk.W)
        col_count += 1
    elif ele == 'Space':
        key_label = tk.Label(root, text=ele, relief="raised", width=53, height=3)
        key_label.grid(row=row_count, column=col_count, columnspan=6, sticky=tk.W)
        col_count += 5
    else:          
        key_label = tk.Label(root, text=ele, relief="raised", width=8, height=3)
        key_label.grid(row=row_count, column=col_count, sticky=tk.W)

#根據每行按鍵數換行
    if col_count >= keyboardLen[row_count]:
        row_count += 1
        col_count = 0
    else: col_count += 1
    key_labels.append(key_label)

#事件綁定
root.bind('<KeyPress>', on_press)
root.bind('<KeyRelease>', on_release)

root.mainloop()