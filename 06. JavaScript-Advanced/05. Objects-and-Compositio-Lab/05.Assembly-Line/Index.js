function createAssemblyLine() {

    const object = {

        hasClima(carObject) {

            carObject['temp'] = 21,
            carObject['tempSettings'] = 21,
            carObject['adjustTemp'] = function adjustTemp() {

                if(carObject.temp < carObject.tempSettings) {
                    carObject.temp++;
                } else if(carObject.temp > carObject.tempSettings) {
                    carObject.temp--;
                }
            }
        },

        hasAudio(carObject) {

            carObject['currentTrack'] = {},
            carObject['nowPlaying'] = function nowPlaying() {

                if(carObject.currentTrack.name != null && carObject.currentTrack.artist != null){
                    console.log(`Now playing '${carObject.currentTrack.name}' by ${carObject.currentTrack.artist}`);
                }
            }
        },

        hasParktronic(carObject) {

            carObject['checkDistance'] = function checkDistance(distance) {

                let printMessage = '';

                if(distance < 0.1) {
                    printMessage = 'Beep! Beep! Beep!';
                } else if(distance < 0.25) {
                    printMessage = 'Beep! Beep!';
                } else if(distance < 0.5) {
                    printMessage = 'Beep!';
                }
                
                console.log(printMessage);
            }
        }
    };
    return object;
}