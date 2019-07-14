import tensorflow as tf
from tensorflow import keras
import numpy as np
import matplotlib.pyplot as plt

data = keras.datasets.fashion_mnist     # Calling the Fashion MNIST Dastaset from TensorFlow

# Defining variables to store the data for testing and training
(train_images, train_labels), (test_images, test_labels) = data.load_data()

class_names = ['T-shirt/top', 'Trouser', 'Pullover', 'Dress', 'Coat',
               'Sandal', 'Shirt', 'Sneaker', 'Bag', 'Ankle Boots']

# Dividing the final RGB values with 255 to give the AI less(shorter) values to work on.
train_images = train_images/255.0
test_images = test_images/255.0

# Specifying the following ...
model = keras.Sequential([
    # The Grid of the input. This will be further converted
    # to be as 784 fully connected neurons.
    keras.layers.Flatten(input_shape=(28, 28)),
    keras.layers.Dense(128, activation="relu"),     # A hidden layer of neurons of "relu" activation.
    keras.layers.Dense(10, activation="softmax")    # Final output layer of 10 neurons.
])

model.compile(optimizer="adam", loss="sparse_categorical_crossentropy", metrics=["accuracy"])

model.fit(train_images, train_labels, epochs=10)

prediction = model.predict(test_images)

for i in range(5):
    plt.grid(False)
    plt.imshow(test_images[i], cmap=plt.cm.binary)
    plt.xlabel("Actual: " + class_names[test_labels[i]])
    plt.title("Prediction: " + class_names[np.argmax(prediction[i])])
    plt.show()

# To Train
#
# test_loss, test_acc = model.evaluate(test_images, test_labels)
#
# print("Tested Acc: ", test_acc)

# To Test and check the List
#
# print(train_images[7])
#
# plt.imshow(train_images[7], cmap=plt.cm.binary)
# plt.show()
