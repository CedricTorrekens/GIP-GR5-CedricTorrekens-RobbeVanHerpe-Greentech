
<!--
          _____                  _______        _
         / ____|                |__   __|      | |
         | |  __ _ __ ___  ___ _ __ | | ___  ___| |__
         | | |_ | '__/ _ \/ _ \ '_ \| |/ _ \/ __| '_ \
         | |__| | | |  __/  __/ | | | |  __/ (__| | | |
          \_____|_|  \___|\___|_| |_|_|\___|\___|_| |_|
-->

<?php
    $db = mysqli_connect('5.189.173.7','root','6ETu%3f8','dbGreenTech')
    or die('Error connecting to MySql server.')
?>


<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8" />
    <title>Demo: Add custom markers in Mapbox GL JS</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="https://fonts.googleapis.com/css?family=Open+Sans"
          rel="stylesheet" />
    <script src="https://api.tiles.mapbox.com/mapbox-gl-js/v2.6.1/mapbox-gl.js"></script>
    <link href="https://api.tiles.mapbox.com/mapbox-gl-js/v2.6.1/mapbox-gl.css"
          rel="stylesheet" />
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons"
          rel="stylesheet">
    <style>
        body {
            margin: 0;
            padding: 0;
        }

        #map {
            position: absolute;
            top: 0;
            bottom: 0;
            width: 100%;
        }

        .marker {
            background-image: url('https://cdn1.iconfinder.com/data/icons/basic-ui-7/100/Artboard_7-512.png');
            background-size: cover;
            width: 50px;
            height: 50px;
            border-radius: 50%;
            cursor: pointer;
        }

        .mapboxgl-popup {
            max-width: 200px;
        }

        .mapboxgl-popup-content {
            text-align: center;
            font-family: 'Open Sans', sans-serif;
        }
    </style>
</head>
<body>

    <div id="map"></div>

    <?php
        $query = "SELECT tblMeetstation.idStation, tblMeetstation.naamStation, tblMeetstation.latStation, tblMeetstation.longStation FROM tblMeetstation, tblStationUsers WHERE tblStationUsers.StationUsr = tblMeetstation.idStation AND tblStationUsers.Userid = '4081';";
        
        $result = mysqli_query($db, $query);



    ?>

    <script>
        mapboxgl.accessToken = 'pk.eyJ1IjoiY2Vkcmljb3QxNSIsImEiOiJja3U5d2o4eGIwYjRzMm9tdmhpeGFrcjlmIn0.FyUnczgFuod7hgZi4GuL_A';

        /*const geojson = {
            'type': 'FeatureCollection',
            'features': [
                {
                    'type': 'Feature',
                    'geometry': {
                        'type': 'Point',
                        'coordinates': [4.099118, 50.949721]
                    },
                    'properties': {
                        'title': 'SMI Moorsel',
                        'description': 'Meetstation: esp8266-6737604'
                    }
                },
                {
                    'type': 'Feature',
                    'geometry': {
                        'type': 'Point',
                        'coordinates': [4.023740, 50.940440]
                    },
                    'properties': {
                        'title': 'SMI Sint-Anna',
                        'description': 'Meetstation: esp8266-3130811'
                    }
                }
            ]
        };*/

        const geojson = {
            'type': 'FeatureCollection',
            'features': [
                <?php

                    while ($row = mysqli_fetch_array($result)) {
                        echo '{' . PHP_EOL;
                        echo '                    \'type\': \'Feature\',' . PHP_EOL;
                        echo '                    \'geometry\': {' . PHP_EOL;
                        echo '                          \'type\': \'Point\',' . PHP_EOL;
                        echo '                          \'coordinates\': [' . $row['longStation'] . ',' . $row['latStation'] . '] ' . PHP_EOL;
                        echo '                    },' . PHP_EOL;
                        echo '                    \'properties\': {' . PHP_EOL;
                        echo '                          \'title\': \'' . $row['naamStation'] . '\',' . PHP_EOL;
                        echo '                          \'description\': \'Meetstation: ' . $row['idStation'] . '\'' . PHP_EOL;
                        echo '                    }' . PHP_EOL;
                        echo '},' . PHP_EOL;
                    }
                ?>
            ]
        };


        const map = new mapboxgl.Map({
            container: 'map',
            style: 'mapbox://styles/cedricot15/ckzpqa0dh000d14nzu2k33acu',
            center: [4.510132, 50.468249],
            zoom: 7.55
        });

        // add markers to map
        for (const feature of geojson.features) {
            // create a HTML element for each feature
            const el = document.createElement('div');
            el.className = 'marker';

            // make a marker for each feature and add it to the map
            new mapboxgl.Marker(el)
                .setLngLat(feature.geometry.coordinates)
                .setPopup(
                    new mapboxgl.Popup({ offset: 25 }) // add popups
                        .setHTML(
                            `<h3>${feature.properties.title}</h3><p>${feature.properties.description}</p>`
                        )
                )
                .addTo(map);
        }

        // Add zoom and rotation controls to the map.
        map.addControl(new mapboxgl.NavigationControl());


    </script>
</body>
</html>
