class DateHelper {
    formatLocalDate = date => {
        let output = '';

        if (date !== null) {
            let monthYearFormat = moment(date, 'MMMM YYYY').format('MMMM YYYY') === date;
            let monthDayYearFormat = moment(date, 'l').format('l') === date;
            if (monthYearFormat) {
                let utcDate = moment.utc(date, 'MMMM YYYY');
                let localDate = utcDate.local();

                output = localDate.format('dddd, MMMM DD, YYYY')
            }

            if (monthDayYearFormat) {
                let utcDate = moment.utc(date, 'l');
                let localDate = utcDate.local();

                output = localDate.format('dddd, MMMM DD, YYYY')
            }

            if (!monthYearFormat && !monthDayYearFormat) {
                let utcDate = moment.utc(date);
                let localDate = utcDate.local();

                output = localDate.format('dddd, MMMM DD, YYYY')
            }
        }

        return output;
    }

    formatShortLocalDate = date => {
        if (!date)
            return '';

        let output = '';

        if (date) {
            let utcDate = moment.utc(date);
            let localDate = utcDate.local();

            output = localDate.format('MM/DD/YYYY')
        }

        return output;
    };

    formatLocalDateTime = date => {
        let output = '';

        if (date) {
            let utcDate = moment.utc(date);
            let localDate = utcDate.local();

            output = localDate.format('MM/DD/YYYY hh:mm A')
        }

        return output;
    };

    formatLocalShortMonthDateTime = date => {
        let output = '';

        if (date) {
            let utcDate = moment.utc(date);
            let localDate = utcDate.local();

            output = localDate.format('MMM DD YYYY (ddd) hh:mm A')
        }

        return output;
    };

    formatLocalShortMonthDay = date => {
        let output = '';

        if (date) {
            let utcDate = moment.utc(date);
            let localDate = utcDate.local();

            output = localDate.format('MMMM DD, YYYY (ddd)')
        }

        return output;
    };

    formatShortDate = date => {
        let output = '';

        if (date)
            output = moment(date).format('MM/DD/YYYY');

        return output;
    };

    formatMonthYear = date => {
        let output = '';

        if (date)
            output = moment(date).format('MMMM yyyy');

        return output;
    };

    serializeUtc = str => {
        return moment.utc(str).format();
    };

    // Changes the date's timezone to UTC 
    // while retaining the original date
    convertToUtcDate = date => {
        let dateString = this.formatLocalDate(date);

        return this.serializeUtc(dateString);
    };

    daysOfWeek = ['Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'];

    getDayOfWeek = date => {
        let day = date.getDay();

        return this.daysOfWeek[day];
    };

    getLocalDayOfWeek = date => {
        let localDate = new Date(this.formatShortLocalDate(date));

        return this.getDayOfWeek(localDate);
    };

    getLocalTime = utcTime => {
        if (!utcTime) 
            return '';

        let date = new Date(`1/1/2000 ${utcTime} UTC`);

        return date.toLocaleTimeString([], { hour: '2-digit', minute: '2-digit' });
    }
}