def btnL():
    if(Label1Text.get() == "這是紅字黃底"):
        Label1Text.set("這是藍字綠底")
        label1.config(bg = "green", fg = "blue")
    else:
        Label1Text.set("這是紅字黃底")
        label1.config(bg = "yellow", fg = "red")
        
def btnEn():
    Msg = enterText.get()
    msgEnText.set("你輸入的文字：" + Msg)
    
def CKRB():
    Msg = RB.get()
    msgRBText.set("你選擇了：" + Msg)
    
def CKCB():
    strr = "你選擇了："
    for i in range(0, len(choice)):
        if(choice[i].get() == 1):
            strr += collection[i] + " "
    msgCBText.set(strr)

#------------------------------------------------------------------------------

import tkinter as tk

win = tk.Tk()         #建立主視窗
win.geometry("420x480")     #設定視窗大小
win.title("主視窗")       #設定視窗標題

Label1Text = tk.StringVar()
Label1Text.set("這是紅字黃底")

label1 = tk.Label(win, textvariable = Label1Text, fg = "red", bg = "yellow",
                  font = ("標楷體", 20))
label1.place(x = 20, y = 30)

btnLabel = tk.Button(win, text = "按我變色", width = 10, height = 2, fg = "black",
                     bg = "white", font = ("標楷體", 14), command = btnL)
btnLabel.place(x = 220, y = 20)

#------------------------------------------------------------------------------

enterText = tk.StringVar()
msgEnText = tk.StringVar()

entry1 = tk.Entry(win, textvariable = enterText, font = ("標楷體", 18), width = 15,
                  bg = "pink")
entry1.place(x = 20, y = 112)

btnLabel = tk.Button(win, text = "按我讀取", width = 10, height = 2, fg = "black",
                     bg = "white", font = ("標楷體", 14), command = btnEn)
btnLabel.place(x = 220, y = 100)

labelMsgEn = tk.Label(win, textvariable = msgEnText)
labelMsgEn.place(x = 20, y = 155)

#------------------------------------------------------------------------------

RB = tk.StringVar()
RBI1 = tk.Radiobutton(win, text = "Item 1", value = "Item 1",
                      variable = RB, font = ("標楷體", 14), command = CKRB)
RBI1.place(x = 20, y = 195)
RBI1.select()
RBI2 = tk.Radiobutton(win, text = "Item 2", value = "Item 2",
                      variable = RB, font = ("標楷體", 14), command = CKRB)
RBI2.place(x = 20, y = 225)
RBI3 = tk.Radiobutton(win, text = "Item 3", value = "Item 3",
                      variable = RB, font = ("標楷體", 14), command = CKRB)
RBI3.place(x = 20, y = 255)

msgRBText = tk.StringVar()
labelMsgRB = tk.Label(win, textvariable = msgRBText)
labelMsgRB.place(x = 130, y = 225)

#------------------------------------------------------------------------------

choice = []
collection = ["第一個","第二個","第三個"]
msgCBText = tk.StringVar()
yco = 300

for i in range(0, len(collection)):
    temp = tk.IntVar()
    choice.append(temp)
    item = tk.Checkbutton(win, text = collection[i], variable = choice[i],
                          font = ("標楷體", 14), command = CKCB)    
    item.place(x = 20, y = yco)
    yco += 30

labelMsgCB = tk.Label(win, textvariable = msgCBText)
labelMsgCB.place(x = 130, y = 330)

#------------------------------------------------------------------------------

win.mainloop() #等候指令直到視窗關閉

#-------------------------------------------------------------------------------