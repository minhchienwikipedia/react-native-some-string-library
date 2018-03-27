# react-native-some-string-library [![npm version](https://badge.fury.io/js/react-native-some-string-library.svg)](https://badge.fury.io/js/react-native-some-string-library)

## Getting started

1.  Automatic installation and link
    `$ react-native install react-native-some-string-library`

2.  Add package
    `$ npm install react-native-some-string-library --save`
    OR
    `$ yarn add react-native-some-string-library`

### Mostly automatic installation

1.  Link
    `$ react-native link react-native-some-string-library`

2.  Unlink
    `$ react-native unlink react-native-some-string-library`

### Manual installation

#### iOS

1.  In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2.  Go to `node_modules` ➜ `react-native-some-string-library` and add `RNSomeStringLibrary.xcodeproj`
3.  In XCode, in the project navigator, select your project. Add `libRNSomeStringLibrary.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4.  Run your project (`Cmd+R`)<

#### Android

1.  Open up `android/app/src/main/java/[...]/MainActivity.java`

* Add `import com.reactlibrary.RNSomeStringLibraryPackage;` to the imports at the top of the file
* Add `new RNSomeStringLibraryPackage()` to the list returned by the `getPackages()` method

2.  Append the following lines to `android/settings.gradle`:
    ```
    include ':react-native-some-string-library'
    project(':react-native-some-string-library').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-some-string-library/android')
    ```
3.  Insert the following lines inside the dependencies block in `android/app/build.gradle`:
    ```
      compile project(':react-native-some-string-library')
    ```

## Use

```javascript
import RNSomeStringLibrary from 'react-native-some-string-library';

// Put value and call back data
RNSomeStringLibrary.hello(val.toString(), data => this.setState({ data }));

// Check string or number
RNSomeStringLibrary.isString(val.toString())
  .then(data => this.setState({ data }, () => console.log('this is string')))
  .catch(data =>
    this.setState({ data: data.message }, () => console.log('this is number'))
  );

// Get info, get some type value
MyCustomModule.getInfo(
              'Iphone',
              4,
              300.012,
              true,
              [1, 'two', 'three'],
              {
                id: 321321,
                name: 'Minh Chien',
                age: 23
              },
              data => this.setState({ data: JSON.stringify(data) })
            )
// Event listener
componentDidMount() {
    this.addListener = myCustomModuleEmitter.addListener('addEvent', event =>
      this.setState({ data: JSON.stringify(event) })
    );
  }

  componentWillUnmount() {
    this.addListener.remove();
  }
```

## Example

```javascript
import React, { Component } from 'react';
import {
  Platform,
  StyleSheet,
  Text,
  View,
  TextInput,
  TouchableOpacity,
  NativeEventEmitter
} from 'react-native';

import RNSomeStringLibrary from 'react-native-some-string-library';

const myCustomModuleEmitter = new NativeEventEmitter(RNSomeStringLibrary);

export default class App extends Component<Props> {
  state = {
    data: '',
    val: ''
  };
  componentDidMount() {
    this.addListener = myCustomModuleEmitter.addListener('addEvent', event =>
      this.setState({ data: JSON.stringify(event) })
    );
  }

  componentWillUnmount() {
    this.addListener.remove();
  }
  render() {
    const { data, val } = this.state;
    return (
      <View style={styles.container}>
        <Text style={styles.welcome}>Welcome to My MyCustomModule!</Text>

        <TextInput
          style={{
            width: 200,
            height: 40,
            borderBottomColor: 'gray',
            borderBottomWidth: 1
          }}
          placeholder="Type..."
          value={val}
          underlineColorAndroid="transparent"
          onChangeText={val =>
            this.setState({
              val
            })
          }
        />
        <Text
          style={styles.text}
          onPress={() =>
            MyCustomModule.hello(val, data => this.setState({ data }))
          }
        >
          Say Hi
        </Text>
        <Text
          style={styles.text}
          onPress={() =>
            MyCustomModule.isString(val)
              .then(data => this.setState({ data: data }))
              .catch(data => this.setState({ data: data.message }))
          }
        >
          Check is string
        </Text>
        <Text
          style={styles.text}
          onPress={() =>
            MyCustomModule.getInfo(
              'Iphone',
              4,
              300.012,
              true,
              [1, 'two', 'three'],
              {
                id: 321321,
                name: 'Minh Chien',
                age: 23
              },
              data => this.setState({ data: JSON.stringify(data) })
            )
          }
        >
          Get Info
        </Text>
        <Text
          style={styles.text}
          onPress={() =>
            MyCustomModule.addEvent('addEvent', {
              value: val.toString(),
              time: new Date().toISOString()
            })
          }
        >
          Add Event
        </Text>

        <Text>{data}</Text>
      </View>
    );
  }
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    justifyContent: 'center',
    alignItems: 'center',
    backgroundColor: '#F5FCFF'
  },
  welcome: {
    fontSize: 20,
    textAlign: 'center',
    margin: 10
  },
  instructions: {
    textAlign: 'center',
    color: '#333333',
    marginBottom: 5
  },
  text: { marginTop: 20, color: '#47A4E0', fontSize: 20 }
});
```

---

## License

This module is [MIT licensed](./LICENSE)

---
