import torchvision
from torch.utils.tensorboard import SummaryWriter

#建立資料初始化函式
dataset_transfrom = torchvision.transforms.Compose([    
    torchvision.transforms.ToTensor()
])

#設定配套資料集
train_set = torchvision.datasets.CIFAR10(root="./Dataset", train=True, transform=dataset_transfrom, download=True)
test_set = torchvision.datasets.CIFAR10(root="./Dataset", train=True, transform=dataset_transfrom, download=True)

writer = SummaryWriter("Trochvision_db\\logs")

for i in range(10):
    img, target = test_set[i]       #一筆圖片資料分爲圖片(img)及Label的位置（target）
    writer.add_image("DataLoad", img, i)

writer.close()

#tensorboard --logdir=Trochvision_db\\logs --port=6007