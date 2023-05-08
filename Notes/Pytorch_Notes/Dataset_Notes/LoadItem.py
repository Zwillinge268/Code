from torch.utils.data import Dataset
from PIL import Image
import os

class myData(Dataset):

    #初始化
    def __init__(self, root_dir, label_dir):     #使用self可以讓變數全域可用
        self.root_dir = root_dir                 #設定根目錄
        self.label_dir = label_dir               #設定標籤目錄
        self.path = os.path.join(self.root_dir, self.label_dir)     #合并目錄路徑
        self.data_list = os.listdir(self.path)     #建立資料List
    
    #取得資料
    def __getitem__(self, index):
        data_name = self.data_list[index]       #設定指定資料檔名
        item_path = os.path.join(self.root_dir, self.label_dir, data_name)    #合成完整檔案路徑
        data = Image.open(item_path)            #開啓資料
        label = self.label_dir                  #設定標籤
        return data, label
    
    #取得資料集大小
    def __len__(self):
        return len(self.data_list)

root_dir = "Dataset\\train"
ants_label_dir = "ants"
bees_label_dir = "bees"
ants_dataset = myData(root_dir, ants_label_dir)
bees_dataset = myData(root_dir, bees_label_dir)
train_dataset = ants_dataset + bees_dataset

img, label = ants_dataset[0]
img.show()

print(len(ants_dataset))
print(len(bees_dataset))