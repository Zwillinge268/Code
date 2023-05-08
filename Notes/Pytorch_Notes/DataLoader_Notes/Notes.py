import torchvision
from torch.utils.data import DataLoader
from torch.utils.tensorboard import SummaryWriter

toTensor = torchvision.transforms.ToTensor()
test_data = torchvision.datasets.CIFAR10("./Dataset", train=False, transform=toTensor, download=True)

#將資料分爲64/batch，打亂資料，使用單綫程跑，剩餘不足一個batch的資料都捨棄
test_loader = DataLoader(dataset=test_data, batch_size=64, shuffle=True, num_workers=0, drop_last=True)

writer = SummaryWriter("DataLoader_Notes\\logs")
for epoch in range(2):
    step = 0
    for data in test_loader:
        imgs, targets = data
        writer.add_images("Epoch {}".format(epoch), imgs, step) #一個batch(data)會加載多張圖片，請使用add_images而非add_image
        step += 1
writer.close()

#tensorboard --logdir=DataLoader_Notes\\logs --port=6007