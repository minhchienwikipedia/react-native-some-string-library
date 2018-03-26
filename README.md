# react-native-some-string-library

## Getting started

`$ npm install react-native-some-string-library --save`

### Mostly automatic installation

`$ react-native link react-native-some-string-library`

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

#### Windows

[Read it! :D](https://github.com/ReactWindows/react-native)

1.  In Visual Studio add the `RNSomeStringLibrary.sln` in `node_modules/react-native-some-string-library/windows/RNSomeStringLibrary.sln` folder to their solution, reference from their app.
2.  Open up your `MainPage.cs` app

* Add `using Some.String.Library.RNSomeStringLibrary;` to the usings at the top of the file
* Add `new RNSomeStringLibraryPackage()` to the `List<IReactPackage>` returned by the `Packages` method

## Example

```javascript
import React, { Component } from 'react';
import {
  Platform,
  StyleSheet,
  Text,
  View,
  Button,
  TextInput
} from 'react-native';
import RNSomeStringLibrary from 'react-native-some-string-library';

export default class App extends Component<Props> {
  state = {
    data: '',
    val: ''
  };
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
          value={val}
          onChangeText={val =>
            this.setState({
              val
            })
          }
        />
        <Button
          title="Say Hello"
          onPress={() =>
            MyCustomModule.hello(val, data => this.setState({ data }))
          }
        />
        <Button
          title="Check is string"
          onPress={() =>
            MyCustomModule.isString(val)
              .then(data =>
                this.setState({ data: data })
              .catch(data =>
                this.setState({ data: data.message })
          }
        />
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
  }
});
```
