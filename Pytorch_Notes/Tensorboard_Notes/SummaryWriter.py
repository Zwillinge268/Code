from torch.utils.tensorboard import SummaryWriter
import numpy as np
from PIL import Image

#建立資料夾
writer = SummaryWriter("Tensorboard_Notes\\logs")

#加入圖片
img_path = "Dataset\\train\\ants\\6240338_93729615ec.jpg"    #指定路徑
img_PIL = Image.open(img_path)     #開啓圖片
img_array = np.array(img_PIL)      #轉換為Numpy格式
writer.add_image("Title", img_array, 1, dataformats='HWC')   #加入標題與圖片，並設定shape為HWC

#加入圖表内容
for i in range(100):
    writer.add_scalar("This is title", 2 * i, i)

writer.close()

#tensorboard --logdir=Tensorboard_Notes\\logs --port=6007  此爲Terminal的開啓指令
#可以在Terminal直接輸入 Launch TensorBoard 指令開啓