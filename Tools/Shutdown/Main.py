import os
import tkinter as tk
import tkinter.messagebox as messagebox
from tkinter import ttk

root = tk.Tk()
root.title("關機程式")
root.configure(background='gainsboro')

#讓視窗在屏幕中間建立
screen_width = root.winfo_screenwidth()
screen_height = root.winfo_screenheight()
x = int((screen_width - root.winfo_reqwidth()) / 2)
y = int((screen_height - root.winfo_reqheight()) / 2)
root.geometry("+{}+{}".format(x, y))

#執行關機排程
def execute():
    choose = methon.get()
    time_h = hour.get()
    time_m = min.get()
    time_s = sec.get()

    if not time_h.isdigit() or not time_m.isdigit() or not time_s.isdigit():
        messagebox.showerror("錯誤", "請輸入有效的時間")
        return

    time = int(time_h)*3600 + int(time_m)*60 + int(time_s)

    if choose == "shutdown":
        command = f"shutdown /s /t {time}"       
    else:
        command = f"shutdown /r /t {time}"

    try: 
        #由於建立排程後不能叠加/更改，所以需先清除再建立   
        os.system("shutdown /a")
        os.system(command)
        messagebox.showinfo("系統排程", "系統將會在%d分鐘後關閉"%(time/60))     
    except:
        messagebox.showerror("錯誤", "無法執行系統排程！")

#清除關機排程
def clear():
    try:
        os.system("shutdown /a")
        messagebox.showinfo("取消", "已清除關機計劃")
    except:
        messagebox.showerror("錯誤", "無法執行系統排程！")

methon = tk.StringVar(value="shutdown")
hour = tk.StringVar(value="0")
min = tk.StringVar(value="0")
sec = tk.StringVar(value="0")

style = ttk.Style()
style.theme_use('default')
style.configure('TSpinbox', arrowsize=20)
rbStyle = ttk.Style()
rbStyle.configure("TRadiobutton", font=("Arial", 12), padding=(0,10,0,10))
btnStyle = ttk.Style()
btnStyle.configure("TButton", font=("Arial", 12), padding=5)

title_label = ttk.Label(root, text="簡易關機工具", font=("Arial",20), padding=(0,10,0,10))
hour_label = ttk.Label(root, text="設定時間（時）：", font=("Arial",12))
hour_spinbox = ttk.Spinbox(root, from_=0, to=999, textvariable=hour, font=("Arial",12), width=15)
min_label = ttk.Label(root, text="設定時間（分）：", font=("Arial",12))
min_spinbox = ttk.Spinbox(root, from_=0, to=60,textvariable=min, font=("Arial",12), width=15)
sec_label = ttk.Label(root, text="設定時間（秒）：", font=("Arial",12))
sec_spinbox = ttk.Spinbox(root, from_=0, to=60,textvariable=sec, font=("Arial",12), width=15)
shutdown_radio = ttk.Radiobutton(root, text="關機", variable=methon, value="shutdown")
restart_radio = ttk.Radiobutton(root, text="重啟", variable=methon, value="restart")
execute_button = ttk.Button(root, text="執行", command=execute)
clear_button = ttk.Button(root, text="清除計劃", command=clear)

title_label.grid(row=0, column=0, columnspan=2)
hour_label.grid(row=1, column=0, sticky="E")
hour_spinbox.grid(row=1, column=1, sticky="W")
min_label.grid(row=2, column=0, sticky="E")
min_spinbox.grid(row=2, column=1, sticky="W")
sec_label.grid(row=3, column=0, sticky="E")
sec_spinbox.grid(row=3, column=1, sticky="W")
shutdown_radio.grid(row=4, column=0, sticky="E")
restart_radio.grid(row=4, column=1, sticky="W")
execute_button.grid(row=5, column=0, sticky="E")
clear_button.grid(row=5, column=1, sticky="W")

root.mainloop()