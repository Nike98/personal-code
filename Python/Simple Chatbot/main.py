
"""

    A simple AI Chatbot for a Cookies Shop.

    The functionality of this Chatbot include:
    -> Greeting the User
    -> Interacting with the User regarding it's name nd age
    -> Providing the User with the information regarding
        what the outlet sells, and the working hours of the outlet.


    P.S. if you make any changes to the .json file,
    please remember to train the AI for the responses.

"""

import nltk
import numpy
import tflearn
import tensorflow
import pickle
import random
import json
from nltk.stem.lancaster import LancasterStemmer

stemmer = LancasterStemmer()

with open("intents.json") as file:
    data = json.load(file)

try:
    with open("data.pickle", "rb") as f:
        words, labels, training, output = pickle.load(f)
except:
    words = []
    labels = []
    docs_x = []
    docs_y = []

    for intent in data["intents"]:
        for pattern in intent["patterns"]:
            wrds = nltk.word_tokenize(pattern)
            words.extend(wrds)
            docs_x.append(wrds)
            docs_y.append(intent["tag"])

        if intent["tag"] not in labels:
            labels.append(intent["tag"])

    words = [stemmer.stem(w.lower()) for w in words if w != "?"]
    words = sorted(list(set(words)))

    labels = sorted(labels)

    training = []
    output = []

    out_empty = [0 for _ in range(len(labels))]

    for x, doc in enumerate(docs_x):
        bag = []

        wrds = [stemmer.stem(w) for w in doc]

        for w in words:
            if w in wrds:
                bag.append(1)
            else:
                bag.append(0)

        output_row = out_empty[:]
        output_row[labels.index(docs_y[x])] = 1

        training.append(bag)
        output.append(output_row)

        with open("data.pickle", "wb") as f:
            pickle.dump((words, labels, training, output), f)

training = numpy.array(training)
output = numpy.array(output)

tensorflow.reset_default_graph()

net = tflearn.input_data(shape=[None, len(training[0])])
net = tflearn.fully_connected(net, 8)
net = tflearn.fully_connected(net, 8)
net = tflearn.fully_connected(net, len(output[0]), activation="softmax")
net = tflearn.regression(net)

model = tflearn.DNN(net)

# model.fit(training, output, n_epoch=2000, batch_size=8, show_metric=True)
# model.save("model.tflearn")

try:
    model.load("model.tflearn")
except:
    model.fit(training, output, n_epoch=2000, batch_size=8, show_metric=True)
    model.save("model.tflearn")


def bag_of_words(sentence, words):
    bag = [0 for _ in range(len(words))]

    sen_words = nltk.word_tokenize(sentence)
    sen_words = [stemmer.stem(word.lower()) for word in sen_words]

    for sen in sen_words:
        for i, w in enumerate(words):
            if w == sen:
                bag[i] = 1

    return numpy.array(bag)


def chat():
    print("\n\nStart talking with the bot (type quit to stop)!")
    while True:
        inp = input("\nYou: ")
        if inp.lower() == "quit":
            break

        results = model.predict([bag_of_words(inp, words)])[0]
        results_index = numpy.argmax(results)
        tag = labels[results_index]

        if results[results_index] > 0.7:
            for tg in data["intents"]:
                if tg['tag'] == tag:
                    responses = tg['responses']

            print(random.choice(responses))
        else:
            print("I didn't get that. Please try a new question.")


chat()
