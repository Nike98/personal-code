
"""

    A Text classification based AI that detects the
    Movie review written in the .txt file,

    The movie review is written in one line in the
    .txt just to compress it and make the AI think it as
    one whole review. Otherwise the AI thinks it as different
    reviews and gives multiple predictions. But the required
    prediction is just one.

    The AI responds with a value of 1 or 0 where 1 means
    good and 0 means bad.

    The AI model uses the Tensorflow model to train and
    develop the AI. It uses the keras library to train
    and learn. The sample data is provided by Tensorflow itself.

    The AI model once trained is saved and can be used to predict
    another review by changing the .txt file.

    The AI takes the input in an Embedded layer, provides the
    further sends the data to the GlobalAveragePoolingID.
    This data is then passed on to the hidden layer of 16 neurons
    which are fully connected and with ReLU activation.
    The output layer has just 1 neuron fully connected to the
    hidden layer. This layer is activated using the Sigmoid
    activation, so the output given by this layer will
    always be between 0 and 1.

"""

import tensorflow as tf
from tensorflow import keras

data = keras.datasets.imdb

(train_data, train_labels), (test_data, test_labels) = data.load_data(num_words=88000)

word_index = data.get_word_index()

word_index = {k: (v + 3) for k, v in word_index.items()}
word_index["<PAD>"] = 0
word_index["<START>"] = 1
word_index["<UNK>"] = 2
word_index["<UNUSED>"] = 3

reverse_word_index = dict([(value, key) for (key, value) in word_index.items()])

train_data = keras.preprocessing.sequence.pad_sequences(
    train_data,
    value=word_index["<PAD>"],
    padding="post",
    maxlen=250)
test_data = keras.preprocessing.sequence.pad_sequences(
    test_data,
    value=word_index["<PAD>"],
    padding="post",
    maxlen=250)


def decode_review(text):
    return " ".join([reverse_word_index.get(i, "?") for i in text])


# Main Model

# Calling the final model
model = keras.models.load_model("model.h5")


# Send all the data to the program in a list format
def review_encode(s):
    encoded = [1]

    for word in s:
        if word.lower() in word_index:
            encoded.append(word_index[word.lower()])
        else:
            encoded.append(2)

    return encoded


# Give the model new data to predict
with open ("test.txt", encoding="utf-8") as file:
    for line in file.readlines():
        nline = \
            line.replace(",", "").replace(".", "").replace("(", "").replace(")", "").replace(":", "").replace("\"", "").strip().split(" ")
        encode = review_encode(nline)
        encode = keras.preprocessing.sequence.pad_sequences(
            [encode],
            value=word_index["<PAD>"],
            padding="post", maxlen=250)
        predict = model.predict(encode)
        print(line)
        print(encode)
        print(predict[0])

# To train and save the model
"""
model = keras.Sequential()
model.add(keras.layers.Embedding(88000, 16))
model.add(keras.layers.GlobalAveragePooling1D())
model.add(keras.layers.Dense(16, activation="relu"))
model.add(keras.layers.Dense(1, activation="sigmoid"))

model.summary()

model.compile(optimizer="adam", loss="binary_crossentropy", metrics=["accuracy"])

x_val = train_data[:10000]
x_train = train_data[10000:]

y_val = train_labels[:10000]
y_train = train_labels[10000:]

fitModel = model.fit(x_train, y_train, epochs=60, batch_size=512, validation_data=(x_val, y_val), verbose=1)

results = model.evaluate(test_data, test_labels)

print(results)


test_review = test_data[5]
predict = model.predict([test_review])
print("Review: ")
print(decode_review(test_review))
print("Prediction: " + str(predict[5]))
print("Actual: " + str(test_labels[5]))

model.save("model.h5")
"""