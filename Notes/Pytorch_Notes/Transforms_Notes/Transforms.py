from PIL import Image
from torch.utils.tensorboard import SummaryWriter
from torchvision import transforms

img_path = "Dataset\\train\\bees\\17209602_fe5a5a746f.jpg"
img = Image.open(img_path)  #PIL格式

writer = SummaryWriter("Transforms_Notes\\logs")

#將圖片轉為Tensor格式
toTensor = transforms.ToTensor()
tensor_img = toTensor(img)
writer.add_image("Tensor_Form_Image", tensor_img)

#Image Normalize
print(tensor_img[0][0][0])     #查看歸一化前的樣本數值
norm = transforms.Normalize([0.5, 0.5, 0.5], [0.5, 0.5, 0.5])   #針對shape三個值分別賦予平均和標準差
img_norm = norm(tensor_img)
print(img_norm[0][0][0])       #查看歸一化後的樣本數值
writer.add_image("Normalize_Image", img_norm)

#Image Resize
resize = transforms.Resize((512, 512))    #設定兩個數值為長寬，一個數值為短邊長度
img_resize = resize(img)                  #輸入為PIL格式，Resize後圖片仍爲PIL格式
img_resize = toTensor(img_resize)         #需要轉換到Tensor格式才可以使用add_image
writer.add_image("Resize_Image", img_resize)

#Compose
resize2 = transforms.Resize(360)
compose = transforms.Compose([resize2, toTensor])  #將Resize 與 ToTensor 組合為單一函式（陣列内函式順序使用）
img_resize2 = compose(img)
writer.add_image("Resize_with_Compose", img_resize2)

#RandomCrop
RandomC = transforms.RandomCrop((100, 100))     #設定剪裁後大小
composeRC = transforms.Compose([RandomC, toTensor])
for i in range(10):     #將圖片多次裁剪
    img_RC = composeRC(img)
    writer.add_image("RandomCrop_with_Compose", img_RC, i)

writer.close()

#tensorboard --logdir=Transforms_Notes\\logs --port=6007